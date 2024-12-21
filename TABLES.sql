CREATE TABLE shop (
    ID_shop INT PRIMARY KEY,
    place VARCHAR(50) NOT NULL,
    income INT,
    expense INT
);

CREATE TABLE product (
    ID_product INT PRIMARY KEY,
	ID_shop INT,
    name_product VARCHAR(100) NOT NULL,
    count_product INT,
    price INT CHECK (price > 0),
	FOREIGN KEY (ID_shop) REFERENCES shop(ID_shop)
);

CREATE TABLE Employee (
    ID_employee SERIAL PRIMARY KEY,
    Login VARCHAR(50) NOT NULL,
    Employee_password VARCHAR(50) NOT NULL,
    Name_employee VARCHAR(50) NOT NULL,
    familia VARCHAR(50) NOT NULL,
    Otchestvo VARCHAR(50),
    Date_of_birth DATE NOT NULL,
    Number_phone VARCHAR(12),
    ID_shop INT,
    salary INT CHECK (salary > 0),
    role_employee VARCHAR(30),
    FOREIGN KEY (ID_shop) REFERENCES shop(ID_shop)
);

CREATE TABLE buy (
    id_buy SERIAL PRIMARY KEY,
    ID_employee INT,
    Date DATE,
    summa INT,
	facted boolean,
    FOREIGN KEY (ID_employee) REFERENCES Employee(ID_employee)
);

CREATE TABLE custom (
    ID_custom SERIAL PRIMARY KEY,
    id_employee INT,
    name_company VARCHAR(100),
    delivery_time DATE,
    FOREIGN KEY (id_employee) REFERENCES Employee(ID_employee)
);

CREATE TABLE product_custom (
    ID_product INT,
    ID_custom INT,
    PRIMARY KEY (ID_product, ID_custom),
    FOREIGN KEY (ID_product) REFERENCES product(ID_product),
    FOREIGN KEY (ID_custom) REFERENCES custom(ID_custom)
);

CREATE TABLE product_buy (
    ID_product INT,
    ID_buy INT,
	price INT,
	count_basket INT,
	discount INT,
    PRIMARY KEY (ID_product, ID_buy),
    FOREIGN KEY (ID_product) REFERENCES product(ID_product),
    FOREIGN KEY (ID_buy) REFERENCES buy(id_buy)
);


