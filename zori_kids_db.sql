-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Gazdă: 127.0.0.1
-- Timp de generare: sept. 23, 2019 la 05:21 PM
-- Versiune server: 10.4.6-MariaDB
-- Versiune PHP: 7.3.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Bază de date: `zori_kids_db`
--

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `admins`
--

CREATE TABLE `admins` (
  `id` int(11) NOT NULL,
  `full_name` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `roles_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Eliminarea datelor din tabel `admins`
--

INSERT INTO `admins` (`id`, `full_name`, `email`, `password`, `roles_id`) VALUES
(6, 'Gabriel Kopacz', 'kopaczgabi@gmail.com', '420w33DsMKG647', 1);

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `asociatie`
--

CREATE TABLE `asociatie` (
  `id` int(11) NOT NULL,
  `denumire` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cod_fiscal` varchar(15) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nr_reg_com` varchar(15) COLLATE utf8mb4_unicode_ci NOT NULL,
  `data_infintare` date NOT NULL,
  `iban` varchar(35) COLLATE utf8mb4_unicode_ci NOT NULL,
  `localitate` varchar(15) COLLATE utf8mb4_unicode_ci NOT NULL,
  `judet` varchar(15) COLLATE utf8mb4_unicode_ci NOT NULL,
  `adresa` varchar(150) COLLATE utf8mb4_unicode_ci NOT NULL,
  `parinte_id` int(11) NOT NULL,
  `copil_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Eliminarea datelor din tabel `asociatie`
--

INSERT INTO `asociatie` (`id`, `denumire`, `cod_fiscal`, `nr_reg_com`, `data_infintare`, `iban`, `localitate`, `judet`, `adresa`, `parinte_id`, `copil_id`) VALUES
(17, 'kuku srl', 'RO31658430', 'j26/546/2019', '2019-09-02', '656758768686986', 'Reghin', 'Mures', 'Bd libertatii bl 14 sc 2 ap 36a1', 16, 41),
(18, 'Aud Culori SRL', 'RO31658430', 'J26/1234/1960', '2019-09-09', '656758768686986', 'Reghin', 'Mures', 'Str Spitalului Nr 11', 15, 40),
(19, 'andone srl', '31658430', 'J26/1234/1960', '2019-09-02', '656758768686986', 'Reghin', 'Mures', 'Str Spicului nr 30', 17, 42),
(20, 'Maritim ex SRL', '1236667', 'J26/1234/1960', '2019-08-26', '656758768686998', 'Targu Mures', 'Mures', 'Unirii 5/20', 18, 43),
(21, 'Queen Security', '31658430', 'j26/546/2019', '2019-09-12', '888666', 'Oxford', 'Maramures', 'Regina Elizabetha nr 1', 19, 44),
(22, 'Carti de citit in timpul vietii', '12345', '223344', '2019-09-23', '323898768686998', 'Reghin', 'Mures', 'Soare nr 2', 20, 45),
(23, 'Mancare gratis', '1236667', '223344', '2019-09-09', '888666', 'Targu Mures', 'Mures', 'ceafa 3', 21, 46),
(24, 'CTC', 'RO11244678', 'J26/1234/1960', '2019-09-04', '8886668653579', 'Bucuresti', 'Sector 3', 'Rahova vest 24', 22, 47),
(25, 'Colinde Romanesti', 'RO31658430', '66779008898', '2019-09-17', '656758768686998', 'Reghin', 'Mures', 'Bd liberta?ii bl 14 sc 2 ap 36a1', 23, 48),
(26, 'Cor de gaini', 'RO31658430', '23889998', '2019-09-23', '888666', 'Reghin', 'Mures', 'Bd liberta?ii bl 14 sc 2 ap 36a1', 24, 49),
(27, 'zordezi', '1236667', '223344', '2019-09-17', '323898768686998', 'Reghin', 'Mures', 'Bd liberta?ii bl 14 sc 2 ap 36a1', 25, 50),
(28, 'exact', '31658430', 'J26/1234/1960', '2019-09-18', '656758768686998', 'Reghin', 'Mures', 'Bd liberta?ii bl 14 sc 2 ap 36a1', 26, 51);

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `asoc_copil`
--

CREATE TABLE `asoc_copil` (
  `Id` int(11) NOT NULL,
  `asoc_id` int(11) NOT NULL,
  `copil_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Eliminarea datelor din tabel `asoc_copil`
--

INSERT INTO `asoc_copil` (`Id`, `asoc_id`, `copil_id`) VALUES
(7, 17, 41),
(8, 18, 40),
(9, 19, 42),
(10, 20, 43),
(11, 21, 44),
(12, 22, 45),
(13, 23, 46),
(14, 24, 47),
(15, 25, 48),
(16, 26, 49),
(17, 27, 50),
(18, 28, 51);

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `asoc_parinte`
--

CREATE TABLE `asoc_parinte` (
  `Id` int(11) NOT NULL,
  `asociatie_id` int(11) NOT NULL,
  `parinte_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Eliminarea datelor din tabel `asoc_parinte`
--

INSERT INTO `asoc_parinte` (`Id`, `asociatie_id`, `parinte_id`) VALUES
(10, 17, 16),
(11, 18, 15),
(12, 19, 17),
(13, 20, 18),
(14, 21, 19),
(15, 22, 20),
(16, 23, 21),
(17, 24, 22),
(18, 25, 23),
(19, 26, 24),
(20, 27, 25),
(21, 28, 26);

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `copil`
--

CREATE TABLE `copil` (
  `id` int(11) NOT NULL,
  `cnp` varchar(13) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nume` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `prenume` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `varsta` date NOT NULL,
  `sex` varchar(15) COLLATE utf8mb4_unicode_ci NOT NULL,
  `vorbeste` varchar(2) COLLATE utf8mb4_unicode_ci NOT NULL,
  `parinte_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Eliminarea datelor din tabel `copil`
--

INSERT INTO `copil` (`id`, `cnp`, `nume`, `prenume`, `varsta`, `sex`, `vorbeste`, `parinte_id`) VALUES
(40, '1234567891123', 'Aida', 'Talida', '2019-09-16', 'Feminin', 'Da', 15),
(41, '1941109566433', 'Popescu ', 'Ioana', '2010-06-08', 'Feminin', 'Da', 16),
(42, '1234455667789', 'Atanasof', 'Bogdan', '2014-06-09', 'Masculin', 'Da', 17),
(43, '1941109134667', 'Ahoi', 'Marin', '2014-08-14', 'Masculin', 'Da', 18),
(44, '2357785543279', 'Printz', 'Iute', '2019-09-05', 'Masculin', 'Da', 19),
(45, '1941109182878', 'Mare', 'Eliada', '2019-09-17', 'Feminin', 'Nu', 20),
(46, '9875457888831', 'Gratar', 'Dumitru', '2019-09-09', 'Masculin', 'Nu', 21),
(47, '1941109182878', 'Hip', 'Hop', '2019-09-19', 'Feminin', 'Nu', 22),
(48, '1234455667789', 'Mic', 'Mistret', '2019-09-18', 'Masculin', 'Nu', 23),
(49, '1941109182878', 'Mare', 'Ana', '2019-10-01', 'Feminin', 'Nu', 24),
(50, '1234455667789', 'Test', 'Adevarat', '2019-09-09', 'Feminin', 'Da', 25),
(51, '1234448996543', 'Test', 'asd', '2019-09-10', 'Feminin', 'Nu', 26);

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `link_roles_menus`
--

CREATE TABLE `link_roles_menus` (
  `id` int(11) NOT NULL,
  `roles_id` int(11) NOT NULL,
  `menus_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Eliminarea datelor din tabel `link_roles_menus`
--

INSERT INTO `link_roles_menus` (`id`, `roles_id`, `menus_id`) VALUES
(47, 2, 1),
(48, 2, 2),
(49, 2, 4),
(50, 2, 5),
(51, 2, 6),
(52, 2, 7),
(65, 1, 1),
(66, 1, 2),
(67, 1, 3),
(68, 1, 4),
(69, 1, 5),
(70, 1, 6),
(71, 1, 7),
(76, 6, 1),
(77, 6, 2),
(78, 6, 4),
(83, 7, 8),
(84, 7, 9),
(85, 7, 10),
(86, 7, 11),
(87, 7, 12);

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `menus`
--

CREATE TABLE `menus` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `icon` varchar(50) NOT NULL,
  `url` varchar(255) DEFAULT NULL,
  `parent_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Eliminarea datelor din tabel `menus`
--

INSERT INTO `menus` (`id`, `name`, `icon`, `url`, `parent_id`) VALUES
(1, 'Dashboard', 'fa fa-dashboard', '/Home', 0),
(2, 'Admins', 'fa fa-users', '/Admins', 0),
(3, 'Create Admin', 'fa fa-plus', '/Admins/Create', 2),
(4, 'Manage Admins', 'fa fa-users', '/Admins/Index', 2),
(5, 'Roles', 'fa fa-lock', '/Roles', 0),
(6, 'Create Role', 'fa fa-lock', '/Roles/Create', 5),
(7, 'Manage Roles', 'fa fa-lock', '/Roles/Index', 5),
(8, 'Home', 'fa fa-user', '/UI', 0),
(9, 'About', 'fa fa-user', '/UI/DespreZORI', 8),
(10, 'Account', 'fa fa-user', '/Account', 0),
(11, 'Login', 'fa fa-users', '/Account/Login', 10),
(12, 'Register', 'fa fa-user', '/Account/Register', 10);

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `parinte`
--

CREATE TABLE `parinte` (
  `id` int(11) NOT NULL,
  `email` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `password` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cnp` varchar(13) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nume` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `prenume` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `varsta` date NOT NULL,
  `sex` varchar(15) COLLATE utf8mb4_unicode_ci NOT NULL,
  `telefon` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `localitate` varchar(15) COLLATE utf8mb4_unicode_ci NOT NULL,
  `judet` varchar(15) COLLATE utf8mb4_unicode_ci NOT NULL,
  `adresa` varchar(150) COLLATE utf8mb4_unicode_ci NOT NULL,
  `roles_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Eliminarea datelor din tabel `parinte`
--

INSERT INTO `parinte` (`id`, `email`, `password`, `cnp`, `nume`, `prenume`, `varsta`, `sex`, `telefon`, `localitate`, `judet`, `adresa`, `roles_id`) VALUES
(15, 'dorublk@gmail.com', 'asdfg123G', '1941109182878', 'Doru', 'Black', '2019-09-02', 'Masculin', '0756036905', 'REGHIN', 'Mures', 'Str Spitalului Nr 11', 7),
(16, 'parinte1@gmail.com', 'asdfg123G', '1950219172645', 'Popescu', 'Ioan', '2019-09-11', 'Masculin', '0764478847', 'Reghin', 'Mures', 'Mihai viteazul nr 5 ap 3', 7),
(17, 'kukac@gmail.com', 'asdfg123G', '1234455667789', 'Atanasof', 'Adriana', '1981-05-04', 'Feminin', '0756036905', 'REGHIN', 'Mures', 'Str Spicului nr 30', 7),
(18, 'gizeh@yahoo.com', 'asdfg123G', '1234447766443', 'Gizeh', 'Egypt', '1964-06-16', 'Feminin', '0764478847', 'Targu Mures', 'Mures', 'Unirii 5/20', 7),
(19, 'deanaP@yahoo.com', 'asdfg123G', '1234455435786', 'Princes', 'Dyeanah', '1934-02-13', 'Feminin', '0756036905', 'Oxford', 'Maramures', 'Str Regina Elizabetha nr 1', 7),
(20, 'Elias@outlook.com', 'asdfg123G', '6543332229987', 'Carte', 'Elias', '2009-02-02', 'Masculin', '0756036905', 'REGHIN', 'Mures', 'str birtului 8', 7),
(21, 'cristi@love.com', 'asdfg123G', '1234567965429', 'Titanic', 'Cristof', '2019-09-11', 'Masculin', '0764478847', 'Targu Mures', 'Mures', 'Gratar 2', 7),
(22, 'deliric1@porc.com', 'asdfg123G', '6669993331110', 'Deliric', 'One', '2019-01-01', 'Masculin', '0764478847', 'Bucuresti', 'Sector 3', 'Rahova vest 24', 7),
(23, 'Doctor@porc.com', 'asdfg123G', '1941219182889', 'Doc ', 'Vlad', '2019-08-31', 'Masculin', '0756036905', 'Bucuresti', 'Sector 1', 'Franare 4', 7),
(24, 'Vlad@porc.com', 'asdfg123G', '9875457888831', 'Drobescu', 'Vlad', '2019-09-02', 'Masculin', '0756036905', 'Bucuresti', 'sector 1', 'aragaz 5', 7),
(25, 'Elena@traian.com', 'asdfg123G', '8764458809044', 'Traian', 'Elena', '2019-09-05', 'Feminin', '0756036905', 'Targu Mures', 'Mures', 'Str zoo nr 56', 7),
(26, 'gtechservicegsm@gmail.com', 'asdfg123G', '1234567891123', 'Test', 'Gabriela', '2019-09-25', 'Feminin', '0756036905', 'Reghin', 'Mures', 'Bd liberta?ii bl 14 sc 2 ap 36a1', 7);

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `parinte_copil`
--

CREATE TABLE `parinte_copil` (
  `Id` int(11) NOT NULL,
  `parinte_id` int(11) NOT NULL,
  `copil_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Eliminarea datelor din tabel `parinte_copil`
--

INSERT INTO `parinte_copil` (`Id`, `parinte_id`, `copil_id`) VALUES
(15, 15, 40),
(16, 16, 41),
(17, 17, 42),
(18, 18, 43),
(19, 19, 44),
(20, 20, 45),
(21, 21, 46),
(22, 22, 47),
(23, 23, 48),
(24, 24, 49),
(25, 25, 50),
(26, 26, 51);

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `roles`
--

CREATE TABLE `roles` (
  `id` int(11) NOT NULL,
  `title` varchar(255) NOT NULL,
  `description` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Eliminarea datelor din tabel `roles`
--

INSERT INTO `roles` (`id`, `title`, `description`) VALUES
(1, 'Manager', 'Super Admin with all rights...'),
(2, 'Supervisor', 'Can View Dashboard, Admins & Roles'),
(6, 'Developer', 'Can View Dashboard &  Admins List'),
(7, 'User', 'User in the UI // Client');

--
-- Indexuri pentru tabele eliminate
--

--
-- Indexuri pentru tabele `admins`
--
ALTER TABLE `admins`
  ADD PRIMARY KEY (`id`),
  ADD KEY `admins_ibfk_1` (`roles_id`);

--
-- Indexuri pentru tabele `asociatie`
--
ALTER TABLE `asociatie`
  ADD PRIMARY KEY (`id`),
  ADD KEY `parinte_id` (`parinte_id`),
  ADD KEY `copil_id` (`copil_id`);

--
-- Indexuri pentru tabele `asoc_copil`
--
ALTER TABLE `asoc_copil`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `asoc_id_for1` (`asoc_id`),
  ADD KEY `copil_id_for1` (`copil_id`) USING BTREE;

--
-- Indexuri pentru tabele `asoc_parinte`
--
ALTER TABLE `asoc_parinte`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `parinte_id` (`parinte_id`),
  ADD KEY `asociatie_id` (`asociatie_id`);

--
-- Indexuri pentru tabele `copil`
--
ALTER TABLE `copil`
  ADD PRIMARY KEY (`id`),
  ADD KEY `parinte_id` (`parinte_id`);

--
-- Indexuri pentru tabele `link_roles_menus`
--
ALTER TABLE `link_roles_menus`
  ADD PRIMARY KEY (`id`),
  ADD KEY `menus_id` (`menus_id`),
  ADD KEY `roles_id` (`roles_id`);

--
-- Indexuri pentru tabele `menus`
--
ALTER TABLE `menus`
  ADD PRIMARY KEY (`id`);

--
-- Indexuri pentru tabele `parinte`
--
ALTER TABLE `parinte`
  ADD PRIMARY KEY (`id`),
  ADD KEY `admins_ibfk_2` (`roles_id`);

--
-- Indexuri pentru tabele `parinte_copil`
--
ALTER TABLE `parinte_copil`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `parinte_id` (`parinte_id`),
  ADD KEY `copil_id` (`copil_id`);

--
-- Indexuri pentru tabele `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT pentru tabele eliminate
--

--
-- AUTO_INCREMENT pentru tabele `admins`
--
ALTER TABLE `admins`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT pentru tabele `asociatie`
--
ALTER TABLE `asociatie`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT pentru tabele `asoc_copil`
--
ALTER TABLE `asoc_copil`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT pentru tabele `asoc_parinte`
--
ALTER TABLE `asoc_parinte`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT pentru tabele `copil`
--
ALTER TABLE `copil`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

--
-- AUTO_INCREMENT pentru tabele `link_roles_menus`
--
ALTER TABLE `link_roles_menus`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=88;

--
-- AUTO_INCREMENT pentru tabele `menus`
--
ALTER TABLE `menus`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT pentru tabele `parinte`
--
ALTER TABLE `parinte`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT pentru tabele `parinte_copil`
--
ALTER TABLE `parinte_copil`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT pentru tabele `roles`
--
ALTER TABLE `roles`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Constrângeri pentru tabele eliminate
--

--
-- Constrângeri pentru tabele `admins`
--
ALTER TABLE `admins`
  ADD CONSTRAINT `admins_ibfk_1` FOREIGN KEY (`roles_id`) REFERENCES `roles` (`id`);

--
-- Constrângeri pentru tabele `asociatie`
--
ALTER TABLE `asociatie`
  ADD CONSTRAINT `copil_asoc` FOREIGN KEY (`copil_id`) REFERENCES `copil` (`id`),
  ADD CONSTRAINT `parinte_asoc` FOREIGN KEY (`parinte_id`) REFERENCES `parinte` (`id`);

--
-- Constrângeri pentru tabele `asoc_copil`
--
ALTER TABLE `asoc_copil`
  ADD CONSTRAINT `rel_asoc_id_for1` FOREIGN KEY (`asoc_id`) REFERENCES `asociatie` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `rel_copil_id_for1` FOREIGN KEY (`copil_id`) REFERENCES `copil` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constrângeri pentru tabele `asoc_parinte`
--
ALTER TABLE `asoc_parinte`
  ADD CONSTRAINT `identificare_parinte` FOREIGN KEY (`parinte_id`) REFERENCES `parinte` (`id`),
  ADD CONSTRAINT `idint_asoc` FOREIGN KEY (`asociatie_id`) REFERENCES `asociatie` (`id`);

--
-- Constrângeri pentru tabele `copil`
--
ALTER TABLE `copil`
  ADD CONSTRAINT `parinte_copil` FOREIGN KEY (`parinte_id`) REFERENCES `parinte` (`id`);

--
-- Constrângeri pentru tabele `link_roles_menus`
--
ALTER TABLE `link_roles_menus`
  ADD CONSTRAINT `link_roles_menus_ibfk_1` FOREIGN KEY (`menus_id`) REFERENCES `menus` (`id`),
  ADD CONSTRAINT `link_roles_menus_ibfk_2` FOREIGN KEY (`roles_id`) REFERENCES `roles` (`id`);

--
-- Constrângeri pentru tabele `parinte`
--
ALTER TABLE `parinte`
  ADD CONSTRAINT `admins_ibfk_3` FOREIGN KEY (`roles_id`) REFERENCES `roles` (`id`);

--
-- Constrângeri pentru tabele `parinte_copil`
--
ALTER TABLE `parinte_copil`
  ADD CONSTRAINT `id_copil` FOREIGN KEY (`copil_id`) REFERENCES `copil` (`id`),
  ADD CONSTRAINT `id_parinte` FOREIGN KEY (`parinte_id`) REFERENCES `parinte` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
