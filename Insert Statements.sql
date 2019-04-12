--Rentals inserts

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (02, to_Date('15-MAR-2018'), 1, to_Date('1-MAR-2018')); 

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (03, to_Date('19-MAR-2018'), 3, to_Date('5-MAR-2018')); 

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (04, to_Date('24-MAR-2018'), 2, to_Date('10-MAR-2018')); 

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (05, to_Date('15-Apr-2018'), 2, to_Date('1-Apr-2018'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (06, to_Date('30-Apr-2018'), 2, to_Date('16-Apr-2018'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (07, to_Date('17-May-2018'), 2, to_Date('3-May-2018'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (08, to_Date('24-May-2018'), 1, to_Date('10-May-2018'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (09, to_Date('26-May-2018'), 3, to_Date('12-May-2018'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (10, to_Date('28-May-2018'), 1, to_Date('14-May-2018'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (11, to_Date('30-May-2018'), 3, to_Date('16-May-2018'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (12, to_Date('30-Aug-2018'), 2, to_Date('16-Aug-2018'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (13, to_Date('15-Sep-2018'), 1, to_Date('1-Aug-2018'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (14, to_Date('15-Oct-2017'), 3, to_Date('1-Oct-2017'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (15, to_Date('17-Oct-2017'), 3, to_Date('3-Oct-2017'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (16, to_Date('24-Oct-2017'), 2, to_Date('10-Oct-2017'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (17, to_Date('1-Nov-2017'), 2, to_Date('17-Oct-2017'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (18, to_Date('16-Nov-2017'), 1, to_Date('2-Nov-2017'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (19, to_Date('14-Dec-2017'), 1, to_Date('2-Dec-2017'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (21, to_Date('17-Dec-2017'), 1, to_Date('3-Dec-2017'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (22, to_Date('19-Dec-2017'), 1, to_Date('5-Dec-2017'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (23, to_Date('25-Dec-2017'), 1, to_Date('9-Dec-2017'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (24, to_Date('30-Dec-2017'), 1, to_Date('16-Dec-2017'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (25, to_Date('15-Jan-2013'), 4, to_Date('1-Jan-2013'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (26, to_Date('17-Jan-2013'), 5, to_Date('3-Jan-2013'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (27, to_Date('20-Jan-2013'), 2, to_Date('6-Jan-2013'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (28, to_Date('15-Feb-2013'), 2, to_Date('1-Feb-2013'));

INSERT INTO Rentals(RentalId, DueDate, MemberId, RentalDate)
VALUES (29, to_Date('21-Feb-2013'), 4, to_Date('7-Feb-2013'));

--RentalItems inserts

INSERT INTO RentalItems(RENTALID, BookId, ReturnDate, RentalItems.Open)
VALUES (02, 04, to_Date('14-MAR-2018'), 'c');

INSERT INTO RentalItems(RENTALID, BookId, ReturnDate, RentalItems.Open)
VALUES (04, 05, to_Date('19-MAR-2018'), 'c');

INSERT INTO RentalItems(RENTALID, BookId, ReturnDate, RentalItems.Open)
VALUES (06, 09, to_Date('21-MAR-2018'), 'c');

INSERT INTO RentalItems(RENTALID, BookId, ReturnDate, RentalItems.Open)
VALUES (02, 10, to_Date('25-MAR-2018'), 'c');

INSERT INTO RentalItems(RENTALID, BookId, ReturnDate, RentalItems.Open)
VALUES (15, 11, to_Date('20-MAR-2018'), 'c');

INSERT INTO RentalItems(RENTALID, BookId, ReturnDate, RentalItems.Open)
VALUES (17, 11, to_Date('20-Apr-2018'), 'c');

INSERT INTO RentalItems(RENTALID, BookId, ReturnDate, RentalItems.Open)
VALUES (17, 9, to_Date('15-May-2018'), 'c');

INSERT INTO RentalItems(RENTALID, BookId, ReturnDate, RentalItems.Open)
VALUES (21, 3, to_Date('15-May-2017'), 'c');

INSERT INTO RentalItems(RENTALID, BookId, ReturnDate, RentalItems.Open)
VALUES (14, 7, to_Date('15-Dec-2017'), 'c');

INSERT INTO RentalItems(RENTALID, BookId, ReturnDate, RentalItems.Open)
VALUES (14, 11, to_Date('19-Mar-2017'), 'c');

INSERT INTO RentalItems(RENTALID, BookId, ReturnDate, RentalItems.Open)
VALUES (22, 6, to_Date('21-Jan-2017'), 'c');

INSERT INTO RentalItems(RENTALID, BookId, ReturnDate, RentalItems.Open)
VALUES (15, 8, to_Date('13-Jan-2017'), 'c');

INSERT INTO RentalItems(RENTALID, BookId, ReturnDate, RentalItems.Open)
VALUES (19, 10, to_Date('10-Jan-2017'), 'c');

INSERT INTO RentalItems(RENTALID, BookId, ReturnDate, RentalItems.Open)
VALUES (12, 7, to_Date('13-Aug-2016'), 'c');

INSERT INTO RentalItems(RENTALID, BookId, ReturnDate, RentalItems.Open)
VALUES (12, 5, to_Date('14-Aug-2016'), 'c');