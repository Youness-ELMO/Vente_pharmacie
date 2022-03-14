create database Vente_pharmacie
use Vente_pharmacie


create table Client (CIN int primary key,
					Genre char check(Genre in ('M','F')),
					Nom varchar(20),
					Prenom varchar(20),
					Tel int, Adresse varchar(50),
					Ville varchar(30),
					 numero_magasin int foreign key references Magasin(numero_magasin) )

create table Magasin ( numero_magasin int primary key,
					Libelle_magasin varchar(40),
					date_creation date,
					Tel int,
					Adresse varchar(50),
					Ville varchar(30))


create table Cheque ( numero_cheque int primary key,
					Date_emission date,
					Montant float,
					url_cheque varchar(15),
					code_motif int foreign key references MotifsRejet(code_motif),
					CIN int foreign key references Client(CIN), 
					code_Banque int foreign key references Banque(code_Banque),
					numero_magasin int foreign key references Magasin(numero_magasin) )

create table MotifsRejet ( code_motif int primary key , libelle_motif varchar(40)) 

create table Banque ( code_Banque int primary key,
						Libelle_banque varchar(50),
						adresse_siege varchar(50),
						Tel int,
						Ville varchar(30) )


