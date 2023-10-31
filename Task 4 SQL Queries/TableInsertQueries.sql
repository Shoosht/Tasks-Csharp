INSERT INTO customers (customer_firstname, customer_lastname, customer_address, customer_phone_number, customer_registration_date, customer_status)
VALUES
    ('Ana', 'Kovačić', 'Trg bana Josipa Jelačića 1', '0953134122', '2023-10-29', 'Inactive'),
    ('Marko', 'Horvat', 'Ulica Nikole Tesle 5', '0952587123', '2023-10-28', 'Inactive'),
    ('Petra', 'Novak', 'Ilica 22', '0951678341', '2023-10-27', 'Inactive'),
    ('Ivan', 'Babić', 'Maksimirska cesta 33', '0957458962', '2023-10-26', 'Inactive'),
    ('Elena', 'Kralj', 'Prilaz Gjure Deželića 7', '0959321567', '2023-10-25', 'Inactive');

SELECT * FROM customers;

INSERT INTO movies (movie_title, movie_genre, movie_year, movie_status)
VALUES
    ('The Shawshank Redemption', 'Drama', '1994-01-01', 'Available'),
    ('The Godfather', 'Crime', '1972-01-01', 'Available'),
    ('The Dark Knight', 'Action', '2008-01-01', 'Available'),
    ('Pulp Fiction', 'Crime', '1994-01-01', 'Available'),
    ('The Lord of the Rings: The Return of the King', 'Adventure', '2003-01-01', 'Available'),
    ('Forrest Gump', 'Drama', '1994-01-01', 'Available'),
    ('Inception', 'Action', '2010-01-01', 'Available'),
    ('Fight Club', 'Drama', '1999-01-01', 'Available'),
    ('The Matrix', 'Action', '1999-01-01', 'Available'),
    ('The Godfather: Part II', 'Crime', '1974-01-01', 'Available'),
	('Casablanca', 'Classic', '1942-01-01', 'Available');


SELECT * FROM movies;