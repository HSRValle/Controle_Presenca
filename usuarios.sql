CREATE TABLE `usuarios` (
  `idUser` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `senha` varchar(45) CHARACTER SET latin1 COLLATE latin1_general_cs DEFAULT NULL,
  `tutor` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`idUser`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
SELECT * FROM new_schema.datas;