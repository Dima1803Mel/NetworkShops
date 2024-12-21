CREATE FUNCTION CheckCountProduct() RETURNS trigger AS $CheckCountProduct$
	BEGIN
		IF NEW.count_product < 0 THEN
			RAISE EXCEPTION 'количество продуктов не может быть меньше нуля';
		END IF;
	END;
$CheckCountProduct$ LANGUAGE plpgsql;

CREATE TRIGGER CheckCountProduct BEFORE INSERT OR UPDATE ON product
	FOR EACH ROW EXECUTE PROCEDURE CheckCountProduct();