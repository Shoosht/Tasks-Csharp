
-- Task 1

/*
Tabelu Posudbe sami dizajnirati da sadrži potrebne informacije o vezi između člana i filma kojeg
je posudio, te vremenskom roku od kad do kad je film rezerviran.
*/

CREATE TABLE rentals (
	rental_id INT IDENTITY(0,1) PRIMARY KEY,
	customer_id INT NOT NULL,
	FOREIGN KEY (customer_id) REFERENCES customers(customer_id),
	movie_id INT NOT NULL,
	FOREIGN KEY (movie_id) REFERENCES movies(movie_ID),
	rental_start_date DATE,
    rental_end_date DATE,
);

DROP TABLE rentals;

-- Task 2

/*
Svaka tabela ima numerički unikatni identifikator (specificirajte kako bi napravili da se ID
automatski povećava za svaki insertirani red)
*/


-- Task 3

/*
Napisati slijedeće SQL upite:
	a. ispisati sve filmove žanra „Akcija“ (SELECT)
	b. ispisati sve posuđene filmove žanra „Akcija“ (SELECT)
	c. ažurirati žanr svih filmova starijih od 1980. na žanr „Klasika“ (UPDATE)
	d. evidentirati povijest posudbe X na dan vraćanja filma u tabelu Povijest Posudbi
		(INSERT+SELECT) te obrisati posudbu X iz tabele Posudbe (DELETE)
	e. ažurirati status svih članova na status „Frequent“ koji imaju arhivirano više od 50 posudbi
		(UPDATE)
*/

-- a. ispisati sve filmove žanra „Akcija“ (SELECT)

SELECT *
FROM movies
WHERE movie_genre = 'Action';

-- b. ispisati sve posuđene filmove žanra „Akcija“ (SELECT)



-- c. ažurirati žanr svih filmova starijih od 1980. na žanr „Klasika“ (UPDATE)



-- d. evidentirati povijest posudbe X na dan vraćanja filma u tabelu Povijest Posudbi
--		(INSERT+SELECT) te obrisati posudbu X iz tabele Posudbe (DELETE)



-- e. ažurirati status svih članova na status „Frequent“ koji imaju arhivirano više od 50 posudbi
--		(UPDATE)