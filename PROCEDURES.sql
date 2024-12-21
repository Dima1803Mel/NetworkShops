CREATE PROCEDURE incertEmployee(login varchar(50), pass varchar(50), name_employee varchar(50), 
familia varchar(50), otchestvo varchar(50), dateBirth date, numberPhone varchar(12),
idShop integer, salary integer, roleEmployee varchar(30))
LANGUAGE SQL
BEGIN ATOMIC
	INSERT INTO employee(login, employee_password, name_employee, familia, otchestvo, date_of_birth, number_phone, id_shop, salary, role_employee)
                          VALUES (login, pass, name_employee, familia, otchestvo, dateBirth, numberPhone, idShop, salary, roleEmployee);

END;

CREATE PROCEDURE deleteEmployee(idEmployee integer)
LANGUAGE SQL
BEGIN ATOMIC
	DELETE FROM employee WHERE id_employee = idEmployee;
END;

CREATE PROCEDURE selectEmployees()
LANGUAGE SQL
BEGIN ATOMIC
	SELECT * FROM employee;
END;

CREATE PROCEDURE selectproduct(idShop integer)
LANGUAGE SQL
BEGIN ATOMIC
	SELECT * FROM product WHERE id_shop = idShop;
END;

CREATE PROCEDURE selectproductbuy()
LANGUAGE SQL
BEGIN ATOMIC
	SELECT * FROM product_buy;
END;

CREATE PROCEDURE selectshop()
LANGUAGE SQL
BEGIN ATOMIC
	SELECT * FROM shop;
END;

CREATE PROCEDURE insertShop(idShop integer, place varchar(50))
LANGUAGE SQL
BEGIN ATOMIC
	INSERT INTO shop(id_shop, place, income, expense)
	VALUES (idShop, place, 0, 0);
END;

CREATE PROCEDURE deleteShop(idShop integer)
LANGUAGE SQL
BEGIN ATOMIC
	DELETE FROM shop WHERE id_shop = idShop;
END;


CREATE OR REPLACE PROCEDURE insertProduct(
    idProduct INTEGER,
    nameProduct VARCHAR(100),
    countProduct INTEGER,
    priceProduct INTEGER
)
LANGUAGE plpgsql AS $$ 
DECLARE product_exists BOOLEAN;
BEGIN
	SELECT EXISTS (
        SELECT 1 FROM product WHERE name_product = nameProduct
    ) INTO product_exists;

    IF product_exists THEN
        -- Если продукт существует, обновляем его количество
        CALL addProduct(nameProduct, countProduct);
    ELSE
        -- Если продукт не существует, вставляем новый продукт
        INSERT INTO product(id_product, name_product, count_product, price)
        VALUES (idProduct, nameProduct, countProduct, priceProduct);
    END IF;
END;
$$;

CREATE OR REPLACE PROCEDURE deleteProduct(idProduct integer)
LANGUAGE plpgsql AS $$
BEGIN
	DELETE FROM product WHERE id_product = idProduct;
END
$$;

CREATE OR REPLACE PROCEDURE addProduct(
    nameProduct VARCHAR(100),
    countProduct INTEGER
)
LANGUAGE plpgsql AS $$
BEGIN
    -- Обновление количества продукта в таблице
    UPDATE product
    SET count_product = count_product + countProduct
    WHERE name_product = nameProduct;
END;
$$;

CREATE OR REPLACE PROCEDURE addListBuy(idProduct integer, countProduct integer, summa integer, discount integer)
LANGUAGE plpgsql AS $$
DECLARE rowCount INT;
DECLARE idBuy INT;
BEGIN
	SELECT COUNT(*) INTO rowCount FROM buy WHERE facted = false;
	IF rowCount = 0 THEN
		INSERT INTO buy(date, summa, facted) VALUES (CURRENT_DATE, 0, false);
	END IF;
	SELECT id_buy INTO idBuy FROM buy WHERE facted = false LIMIT 1;

	IF EXISTS (SELECT 1 FROM product_buy WHERE id_product = idProduct) THEN
		UPDATE product_buy SET count_basket = count_basket + countProduct
		WHERE id_product = idProduct;
	ELSE
		INSERT INTO product_buy(id_product, id_buy, discount, count_basket, summa)
		VALUES (idProduct, idBuy, discount, countProduct, summa);
	END IF;
	
END;
$$;


CREATE OR REPLACE PROCEDURE buyProducts()
LANGUAGE plpgsql AS $$
DECLARE rec RECORD;
BEGIN
	FOR rec IN SELECT id_product, count_basket, summa, id_buy FROM product_buy LOOP
		-- Обновляем количество товаров в магазине
		UPDATE product SET count_product = count_product - rec.count_basket
		WHERE id_product = rec.id_product;

		--Обновляем доход магазина
		UPDATE shop SET income = income + rec.summa
		WHERE id_shop = (SELECT id_shop FROM product WHERE id_product = rec.id_product LIMIT 1);

		--Обновляем сумму покупки
		UPDATE buy SET summa = summa + rec.summa
		WHERE id_buy = rec.id_buy;
		
	END LOOP;
	
	
	UPDATE buy SET facted = TRUE WHERE rec.id_buy IN (SELECT id_buy FROM buy);
	DELETE FROM product_buy;
END;
$$;


