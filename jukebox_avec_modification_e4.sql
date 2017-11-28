-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Mar 28 Novembre 2017 à 11:58
-- Version du serveur :  5.6.17
-- Version de PHP :  5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `jukebox`
--

DELIMITER $$
--
-- Procédures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `Ajout_cd`(IN `titre` VARCHAR(25), IN `duree` VARCHAR(25), IN `enstock` TINYINT(1), IN `commentaire` VARCHAR(25), IN `artiste` VARCHAR(25), IN `nbpiste` INT(16), IN `prix` VARCHAR(25))
begin
Declare var_id INT;
SET var_id = (Select max(id) from support) + 1;
Insert into support values(var_id, titre, duree, enstock, commentaire);
Insert into cd values(artiste, nbpiste, prix, var_id);
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Ajout_dvd`(IN `titre` VARCHAR(25), IN `duree` VARCHAR(25), IN `enstock` TINYINT(1), IN `commentaire` VARCHAR(25), IN `metteurenscene` VARCHAR(25))
begin
Declare var_id INT;
SET var_id = (Select max(id) from support) + 1;
Insert into support values(var_id, titre, duree, enstock, commentaire);
Insert into dvd values(metteurenscene, var_id);
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Delete_cd`(IN `var_id` INT(16))
begin
delete from cd where id = var_id;
delete from support where id = var_id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Delete_dvd`(IN `var_id` INT(16))
begin
delete from dvd where id = var_id;
delete from support where id = var_id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Modif_cd`(IN `var_id` INT(16), IN `var_titre` VARCHAR(25), IN `var_duree` VARCHAR(25), IN `var_enstock` TINYINT(1), IN `var_commentaire` VARCHAR(25), IN `var_artiste` VARCHAR(25), IN `var_nbpiste` INT(16), IN `var_prix` VARCHAR(25))
begin
Update support set titre = var_titre, duree = var_duree, enstock = var_enstock, commentaire = var_commentaire where id = var_id;
Update cd set artiste =var_artiste, nbpiste = var_nbpiste, prix = var_prix where id = var_id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Modif_dvd`(IN `var_id` INT(16), IN `var_titre` VARCHAR(25), IN `var_duree` VARCHAR(25), IN `var_enstock` TINYINT(1), IN `var_commentaire` VARCHAR(25), IN `var_metteurenscene` VARCHAR(25))
begin
Update support set titre = var_titre, duree = var_duree, enstock = var_enstock, commentaire = var_commentaire where id = var_id;
Update dvd set metteurenscene =var_metteurenscene where id = var_id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Rendre`(IN `id_cd` INT)
begin
Declare var_id INT;
SET var_id = (Select max(num_emprunt) from emprunt where id_support = id_cd);
Update emprunt set rendu = 1 where num_emprunt = var_id;
end$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `cd`
--

CREATE TABLE IF NOT EXISTS `cd` (
  `artiste` varchar(25) DEFAULT NULL,
  `nbpiste` int(11) DEFAULT NULL,
  `prix` varchar(25) DEFAULT NULL,
  `id` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `cd`
--

INSERT INTO `cd` (`artiste`, `nbpiste`, `prix`, `id`) VALUES
('bn,vb', 5, 'ghjk', 2),
('sfdserf', 5, '100', 3),
('qsdfg', 5, '2000', 4),
('', 0, '0', 5);

-- --------------------------------------------------------

--
-- Structure de la table `chambre`
--

CREATE TABLE IF NOT EXISTS `chambre` (
  `num_chambre` int(11) NOT NULL,
  `prixC` float DEFAULT NULL,
  `etat` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`num_chambre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `chambre`
--

INSERT INTO `chambre` (`num_chambre`, `prixC`, `etat`) VALUES
(101, 4123, 'ddfgh'),
(102, 456, 'azerty');

-- --------------------------------------------------------

--
-- Structure de la table `dvd`
--

CREATE TABLE IF NOT EXISTS `dvd` (
  `metteurenscene` varchar(25) DEFAULT NULL,
  `id` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `dvd`
--

INSERT INTO `dvd` (`metteurenscene`, `id`) VALUES
('machin', 0);

-- --------------------------------------------------------

--
-- Structure de la table `emprunt`
--

CREATE TABLE IF NOT EXISTS `emprunt` (
  `num_emprunt` int(11) NOT NULL AUTO_INCREMENT,
  `date_emprunt` date DEFAULT NULL,
  `rendu` tinyint(1) DEFAULT NULL,
  `num_chambre` int(11) DEFAULT NULL,
  `id_support` int(11) DEFAULT NULL,
  PRIMARY KEY (`num_emprunt`),
  KEY `FK_Emprunt_num_chambre` (`num_chambre`),
  KEY `FK_Emprunt_id_support` (`id_support`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Contenu de la table `emprunt`
--

INSERT INTO `emprunt` (`num_emprunt`, `date_emprunt`, `rendu`, `num_chambre`, `id_support`) VALUES
(1, '2017-11-28', 1, 102, 4),
(2, '2017-11-28', 1, 102, 3),
(3, '2017-11-28', 1, 101, 2),
(4, '2017-11-28', 1, 101, 2);

-- --------------------------------------------------------

--
-- Structure de la table `support`
--

CREATE TABLE IF NOT EXISTS `support` (
  `id` int(11) NOT NULL,
  `titre` varchar(25) DEFAULT NULL,
  `duree` varchar(25) DEFAULT NULL,
  `enstock` tinyint(1) DEFAULT NULL,
  `commentaire` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `support`
--

INSERT INTO `support` (`id`, `titre`, `duree`, `enstock`, `commentaire`) VALUES
(0, 'abba', '25', 0, 'hahahah'),
(2, 'thsjskn', 'ghjk', 1, 'cvbn,'),
(3, 'sefr', '15', 1, 'sdfgh'),
(4, 'sdf', '30', 1, 'xcvb'),
(5, '', '0', 0, '');

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `cd`
--
ALTER TABLE `cd`
  ADD CONSTRAINT `FK_CD_id` FOREIGN KEY (`id`) REFERENCES `support` (`id`);

--
-- Contraintes pour la table `dvd`
--
ALTER TABLE `dvd`
  ADD CONSTRAINT `FK_DVD_id` FOREIGN KEY (`id`) REFERENCES `support` (`id`);

--
-- Contraintes pour la table `emprunt`
--
ALTER TABLE `emprunt`
  ADD CONSTRAINT `FK_Emprunt_id_support` FOREIGN KEY (`id_support`) REFERENCES `support` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Emprunt_num_chambre` FOREIGN KEY (`num_chambre`) REFERENCES `chambre` (`num_chambre`) ON DELETE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
