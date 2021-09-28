USE master
GO

INSERT INTO EMPRESA (nomeEmpresa)
VALUES ('LOCALIZA'), ('RENTAL');
GO

TRUNCATE TABLE VEICULO 


DELETE FROM EMPRESA
WHERE idEmpresa = 2


INSERT INTO MARCA (nomeMarca)
VALUES ('CHEVROLET'), ('BMW'), ('FORD');
GO

INSERT INTO CLIENTE (nomeCliente,sobrenomeCliente,CNH)
VALUES ('JAILSON','SILVA','12345678900'), ('TAMASHI','SAN','');
GO

INSERT INTO MODELO (idMarca, nomeModelo)
VALUES (1,'AGILE'), (2,'X2'), (3,'FIESTA');
GO

INSERT INTO VEICULO ( idEmpresa, idModelo, placaVeiculo)
VALUES (1, 1, '123ABCD'),
       (1, 2, 'ABC1234'),
	   (2, 3, '1234ABC'), 
	   (2, 1, 'ABCD123');
GO

INSERT INTO ALUGUEL (idCliente, idVeiculo, dataInicio, dataFim)
VALUES (6,1,'28/09/2021','08/10/2021'),
       (6,2,'29/09/2021','09/10/2021'), 
       (7,3,'30/09/2021','10/10/2021'),
	   (7,4,'01/10/2021','11/10/2021');
GO