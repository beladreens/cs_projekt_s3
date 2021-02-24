/*CREATE DATABASE db_Webtoons 

GO*/

 

USE db_Webtoons 

go 

 

CREATE TABLE authors( 

author_id INT IDENTITY(1,1) PRIMARY KEY, 

[name] char(15), 

surname char(20), 

) 

 

INSERT INTO authors ([name], surname) values ('Soryeong', 'Gi'), 

('Makoto', 'Yukimura'), 

('Kouhei', 'Horikoshi'); 

 

INSERT INTO authors ([name]) values ('POGO'); 

 

CREATE TABLE orig_publishers( 

o_publisher_id INT IDENTITY(1,1) PRIMARY KEY, 

[name] nvarchar(15), 

[language] nchar(15), 

) 

 

INSERT INTO orig_publishers ([name], [language]) values ('Naver', 'korean'), 

('Kodansha', 'japanese'), 

('Shueisha', 'japanese'); 

 

CREATE TABLE for_publishers( 

f_publisher_id INT IDENTITY(1,1) PRIMARY KEY, 

[name] nvarchar(15), 

[language] nchar(15), 

) 

 

INSERT INTO for_publishers ([name], [language]) values ('Hanami', 'polish'), 

('Waneko', 'polish'), 

('LINE Webtoon', 'english'); 

 

CREATE TABLE webtoons ( 

series_id INT IDENTITY(1,1) PRIMARY KEY, 

title nvarchar(50), 

[status] char(10) CHECK([status] IN ('ongoing', 'completed')), 

main_category char(11) CHECK(main_category IN ('romance', 'fantasy', 'action', 'sci-fi', 'historical')), 

date_of_publication date, 

author_id int, 

o_publisher_id int, 

f_publisher_id int, 

 

CONSTRAINT ref_auth_web FOREIGN KEY(author_id) 

REFERENCES authors 

ON DELETE no action, 

 

CONSTRAINT ref_opub_web  FOREIGN KEY (o_publisher_id) 

REFERENCES	orig_publishers(o_publisher_id) 

ON DELETE no action, 

 

CONSTRAINT ref_fpub_web FOREIGN KEY (f_publisher_id) 

REFERENCES for_publishers(f_publisher_id) 

ON DELETE no action, 

) 

 

INSERT INTO webtoons (title, [status], main_category, date_of_publication, author_id, o_publisher_id) 

values ('Solo Leveling', 'ongoing', 'fantasy', '2018-03-04', '1', '1'); 

 

INSERT INTO webtoons (title, [status], main_category, date_of_publication, author_id, o_publisher_id, f_publisher_id) 

values ('Vinland Saga', 'ongoing', 'historical', '2005-04-13', '2', '2', '1'), 

('Boku no Hero Academia', 'ongoing', 'sci-fi', '2014-07-07', '3', '3', '2'), 

('Lessa', 'completed', 'fantasy', '2012-06-21', '4', '1', '3'); 

 

CREATE TABLE characters ( 

[name] nvarchar(15), 

surname nvarchar(15), 

character_type  char(10) CHECK(character_type IN ('main', 'secondary', 'supporting')), 

series_id int, 

 

CONSTRAINT ref_web__char FOREIGN KEY(series_id) 

REFERENCES webtoons(series_id) 

ON DELETE no action on update cascade, 

) 

 

INSERT INTO characters([name], surname, character_type, series_id)  

values ('Jin-Woo', 'Sung', 'main', '1'), 

('Jin-Ho', 'Yoo', 'supporting', '1'); 

 

INSERT INTO characters([name], character_type, series_id)  

values ('Thorfinn', 'main', '2'), 

('Askeladd', 'main', '2'); 

 

INSERT INTO characters([name], surname, character_type, series_id)  

values ('Shouto', 'Todoroki', 'secondary', '3'); 

 

CREATE TABLE animated_series ( 

anime_title nvarchar(30), 

broadcast date, 

n_ep int, 

series_id int, 

 

CONSTRAINT ref_web__anime FOREIGN KEY(series_id) 

REFERENCES webtoons(series_id) 

ON DELETE no action on update cascade, 

) 

 

INSERT INTO animated_series (anime_title, broadcast, n_ep, series_id)  

values ('Vinland Saga', '2019-07-07', '22', '2'), 

('Boku no Hero Academia', '2016-04-03', '13', '3'), 

('Boku no Hero Academia 2', '2017-04-02', '25', '3'), 

('Boku no Hero Academia 3', '2018-04-07', '25', '3'); 