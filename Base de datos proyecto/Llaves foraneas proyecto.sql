--Llaves foraneas

--llave foranea productos a marca
ALTER TABLE Productos
ADD FOREIGN KEY(id_marca) REFERENCES Marca(id_marca);

