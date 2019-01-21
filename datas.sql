SELECT * FROM new_schema.datas;CREATE TABLE `datas` (
  `iddata` int(11) NOT NULL AUTO_INCREMENT,
  `dataEsperada` datetime NOT NULL,
  `dataReal` datetime DEFAULT NULL,
  `idAluno` int(11) NOT NULL,
  `noHorario` tinyint(4) DEFAULT NULL,
  `presente` tinyint(4) DEFAULT '0',
  `justificativa` text,
  `idTutor` int(11) DEFAULT NULL,
  PRIMARY KEY (`iddata`),
  UNIQUE KEY `iddata_UNIQUE` (`iddata`),
  UNIQUE KEY `unique_index` (`dataEsperada`,`idAluno`),
  KEY `fk_aluno_idx` (`idAluno`),
  KEY `fk_tutor_idx` (`idTutor`),
  CONSTRAINT `fk_aluno` FOREIGN KEY (`idAluno`) REFERENCES `usuarios` (`idUser`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tutor` FOREIGN KEY (`idTutor`) REFERENCES `usuarios` (`idUser`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;
