INSERT INTO shop(
	id_shop, place, income, expense)
	VALUES (1, 'город Владимир ул.Мира 4', 0, 0),
	(2, 'город Владимир, пр.Строителей 9', 0, 0),
	(3, 'город Владимир, ул.Дворянская 9', 0, 0);

INSERT INTO product(
	id_product, id_shop, name_product, count_product, price)
	VALUES (2, 1, 'Молоко 3.2% жирности 1л.', 15, 200),
	(3, 1, 'Молоко 2.5% жирности 1.', 14, 160),
	(4, 1, 'Картошка 1 кг', 50, 90),
	(5, 2, 'Хлеб', 10, 65),
	(6, 2, 'Кефир 0.5 л', 5, 70);

INSERT INTO employee(
	login, employee_password, name_employee, familia, otchestvo, date_of_birth, number_phone, id_shop, salary, role_employee)
	VALUES ('dimond', 'rome2', 'dima', 'melov', 'sergeevich', '2003-03-18', '+79049552379', 1, 50000, 'кадровик'),
	('login123', 'attila', 'Дан', 'Карпов', 'Дмитриевич', '2003-06-04', '+79991232345', 1, 35000, 'продавец'),
	('qwerty', 'vtisthebest', 'Влад', 'Скоб', 'Игорьевич', '2003-06-03', '+79995552345', 1, 80000, 'директор магазина');

INSERT INTO buy(id_employee, date, summa, facted)
	VALUES(2, '2024-12-12', 0, false)



