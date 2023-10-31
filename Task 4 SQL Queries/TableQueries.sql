CREATE TABLE customers (
	customer_id INT IDENTITY(0,1) PRIMARY KEY,
	customer_firstname VARCHAR(30),
	customer_lastname VARCHAR(30),
	customer_address VARCHAR(60),
	customer_phone_number VARCHAR(10),
	customer_registration_date DATE,
	customer_status VARCHAR(20)
);

DROP TABLE customers;

CREATE TABLE movies (
	movie_ID INT IDENTITY(0,1) PRIMARY KEY,
	movie_title VARCHAR(80),
	movie_genre VARCHAR(20),
	movie_year DATE,
	movie_status VARCHAR(20),
);

DROP TABLE movies;