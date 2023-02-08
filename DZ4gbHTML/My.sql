— create
CREATE TABLE EMPLOYEE (
empID INTEGER PRIMARY KEY AUTO_INCREMENT,
name TEXT NOT NULL,
age TEXT NOT NULL,
address TEXT NOT NULL
);

— insert
INSERT INTO EMPLOYEE (name, age, address) VALUES ('Саша','16','Москва');
INSERT INTO EMPLOYEE (name, age, address) VALUES ('Женя','19','Орёл');
INSERT INTO EMPLOYEE (name, age, address) VALUES ('Наташа','19','Москва');
INSERT INTO EMPLOYEE (name, age, address) VALUES ('Рома','23','Уфа');
INSERT INTO EMPLOYEE (name, age, address) VALUES ('Таня','21','Омск');
INSERT INTO EMPLOYEE (name, age, address) VALUES ('Елена','27','Брянск');
INSERT INTO EMPLOYEE (name, age, address) VALUES ('Семен','18','Москва');
INSERT INTO EMPLOYEE (name, age, address) VALUES ('Никита','20','Уфа');

— fetch
SELECT name FROM EMPLOYEE where age between 18 and 30 and address="Москва"

