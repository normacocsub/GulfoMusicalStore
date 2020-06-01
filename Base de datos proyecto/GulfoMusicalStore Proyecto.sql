CREATE TABLE barrio (
    sk_barrio        NUMBER(3) NOT NULL,
    nombre           VARCHAR2(20) NOT NULL,
    lugar_sk_lugar   NUMBER(3) NOT NULL
);

ALTER TABLE barrio ADD CONSTRAINT barrio_pk PRIMARY KEY ( sk_barrio );

CREATE TABLE client_factura (
    cliente_id_clientte   VARCHAR2(12) NOT NULL,
    factura_factura_id    NUMBER NOT NULL,
    fecha                 DATE
);

ALTER TABLE client_factura ADD CONSTRAINT client_factura_pk PRIMARY KEY ( cliente_id_clientte,
                                                                          factura_factura_id );

CREATE TABLE cliente (
    id_clientte       VARCHAR2(12) NOT NULL,
    primernombre      VARCHAR2(20) NOT NULL,
    segundonombre     VARCHAR2(20),
    primerapellido    VARCHAR2(20) NOT NULL,
    segundoapellido   VARCHAR2(20),
    correo            VARCHAR2(50),
    telefono          VARCHAR2(10),
    direccion         VARCHAR2(30),
    lugar_sk_lugar    NUMBER(3) NOT NULL
);

ALTER TABLE cliente ADD CONSTRAINT cliente_pk PRIMARY KEY ( id_clientte );
ALTER TABLE cliente ADD Barrio_Sk_Barrio number(3);

CREATE TABLE curso (
    sk_curso   NUMBER(3) NOT NULL,
    nombre     VARCHAR2(20),
    estado     VARCHAR2(20),
    fecha      DATE
);

ALTER TABLE curso ADD CONSTRAINT curso_pk PRIMARY KEY ( sk_curso );
ALTER TABLE curso ADD Precio number(8,2);
ALTER TABLE curso modify fecha varchar2(15);

CREATE TABLE curso_factura (
    factura_factura_id    NUMBER NOT NULL,
    curso_sk_curso        NUMBER(3) NOT NULL,
    precio                NUMBER(8, 2) NOT NULL,
    fecha                 DATE,
    cliente_id_clientte   VARCHAR2(12) NOT NULL
);

ALTER TABLE curso_factura ADD CONSTRAINT curso_factura_pk PRIMARY KEY ( factura_factura_id,
                                                                        curso_sk_curso );

CREATE TABLE factura (
    sk_factura   NUMBER(3),
    fecha        DATE,
    factura_id   NUMBER NOT NULL,
    estado       VARCHAR2(10) DEFAULT 'ACTIVO',
    subtotal     NUMBER(8, 2),
    iva          NUMBER(8, 2),
    total        NUMBER(10, 2),
    cantidad     NUMBER(2)
);

ALTER TABLE factura ADD CONSTRAINT factura_pk PRIMARY KEY ( factura_id );

CREATE TABLE lugar (
    sk_lugar   NUMBER(3) NOT NULL,
    ciudad     VARCHAR2(20)
);

ALTER TABLE lugar ADD CONSTRAINT lugar_pk PRIMARY KEY ( sk_lugar );

CREATE TABLE marca (
    sk_marca   NUMBER(3) NOT NULL,
    nombre     VARCHAR2(20) NOT NULL
);

ALTER TABLE marca ADD CONSTRAINT marca_pk PRIMARY KEY ( sk_marca );

CREATE TABLE product_factura (
    factura_factura_id     NUMBER NOT NULL,
    producto_id_producto   VARCHAR2(5) NOT NULL,
    precio                 NUMBER(8, 2) NOT NULL,
    fecha                  DATE,
    cliente_id_clientte    VARCHAR2(12) NOT NULL
);

ALTER TABLE product_factura ADD CONSTRAINT product_factura_pk PRIMARY KEY ( factura_factura_id,
                                                                            producto_id_producto );

CREATE TABLE producto (
    id_producto      VARCHAR2(5) NOT NULL,
    nombre           VARCHAR2(20),
    precio           NUMBER(8, 2),
    marca_sk_marca   NUMBER(3) NOT NULL
);

ALTER TABLE producto ADD CONSTRAINT producto_pk PRIMARY KEY ( id_producto );

ALTER TABLE barrio
    ADD CONSTRAINT barrio_lugar_fk FOREIGN KEY ( lugar_sk_lugar )
        REFERENCES lugar ( sk_lugar );

ALTER TABLE client_factura
    ADD CONSTRAINT client_factura_cliente_fk FOREIGN KEY ( cliente_id_clientte )
        REFERENCES cliente ( id_clientte );

ALTER TABLE client_factura
    ADD CONSTRAINT client_factura_factura_fk FOREIGN KEY ( factura_factura_id )
        REFERENCES factura ( factura_id );

ALTER TABLE cliente
    ADD CONSTRAINT cliente_lugar_fk FOREIGN KEY ( lugar_sk_lugar )
        REFERENCES lugar ( sk_lugar );

ALTER TABLE cliente
    ADD CONSTRAINT cliente_barrio_fk FOREIGN KEY ( barrio_sk_barrio )
        REFERENCES barrio (sk_barrio);

ALTER TABLE curso_factura
    ADD CONSTRAINT curso_factura_cliente_fk FOREIGN KEY ( cliente_id_clientte )
        REFERENCES cliente ( id_clientte );

ALTER TABLE curso_factura
    ADD CONSTRAINT curso_factura_curso_fk FOREIGN KEY ( curso_sk_curso )
        REFERENCES curso ( sk_curso );

ALTER TABLE curso_factura
    ADD CONSTRAINT curso_factura_factura_fk FOREIGN KEY ( factura_factura_id )
        REFERENCES factura ( factura_id );

ALTER TABLE product_factura
    ADD CONSTRAINT product_factura_cliente_fk FOREIGN KEY ( cliente_id_clientte )
        REFERENCES cliente ( id_clientte );

ALTER TABLE product_factura
    ADD CONSTRAINT product_factura_factura_fk FOREIGN KEY ( factura_factura_id )
        REFERENCES factura ( factura_id );

ALTER TABLE product_factura
    ADD CONSTRAINT product_factura_producto_fk FOREIGN KEY ( producto_id_producto )
        REFERENCES producto ( id_producto );

ALTER TABLE producto
    ADD CONSTRAINT producto_marca_fk FOREIGN KEY ( marca_sk_marca )
        REFERENCES marca ( sk_marca );

--SECUENCIAS

CREATE SEQUENCE SEQUENCE_MARCA INCREMENT BY 1 START WITH 1 MAXVALUE 100 MINVALUE 1;
CREATE SEQUENCE Cursos_SEQUENCIA INCREMENT BY 1 START WITH 1 MAXVALUE 100 MINVALUE 1 CACHE 20 ORDER;
CREATE SEQUENCE LUGAR_SEQUENCIA INCREMENT BY 1 START WITH 1 MAXVALUE 100 MINVALUE 1 CACHE 20 ORDER;
CREATE SEQUENCE BARRIO_SEQUENCIA INCREMENT BY 1 START WITH 1 MAXVALUE 100 MINVALUE 1 CACHE 20 ORDER;
--Sinonimos

CREATE PUBLIC SYNONYM Products FOR Producto;
CREATE PUBLIC SYNONYM Brands FOR Marca;
CREATE PUBLIC SYNONYM Courses FOR Curso;
CREATE PUBLIC SYNONYM Place FOR lugar;
CREATE PUBLIC SYNONYM Neigh FOR Barrio;
CREATE PUBLIC SYNONYM Clients FOR CLiente;

--TRIGGERS MARCA
CREATE OR REPLACE TRIGGER MARCA_TRIGGER_SK_KEY
BEFORE INSERT ON Brands
FOR EACH ROW 
BEGIN
    SELECT SEQUENCE_MARCA.NEXTVAL
    INTO:NEW.sk_marca
    FROM DUAL;
END;

--TRIGGERS CURSO
create or replace trigger Cursos_TRIGGER
before insert on Courses
for each row
begin
select cursos_Sequencia.nextval
into:new.sk_curso
from dual;
end;

--TRIGGERS LUGAR

CREATE OR REPLACE TRIGGER SEQUENCIA_TRIGGER_LUGAR
BEFORE INSERT ON Place
FOR EACH ROW
BEGIN
    SELECT LUGAR_SEQUENCIA.NEXTVAL
    INTO:NEW.sk_lugar
    FROM DUAL;
END;

--TRIGGERS BARRIO

CREATE OR REPLACE TRIGGER SEQUENCIA_TRIGGER_BARRIO
BEFORE INSERT ON Neigh
FOR EACH ROW
BEGIN
    SELECT BARRIO_SEQUENCIA.NEXTVAL
    INTO:NEW.sk_barrio
    FROM DUAL;
END;


--Procedimiento cliente

create or replace procedure GuardarCLientes(cedula in VARCHAR2,primername in varchar2, segundoname in varchar2, primerape in varchar2,
                                              segundoape in varchar2,  email in varchar2, phone in varchar2,
                                              city in varchar2, barriocliente in varchar2, direction in varchar2)
  as
  begin
    insert into clientes(id_cliente,primernombre,segundonombre,primerapellido,segundoapellido,correo,telefono,ciudad,
                                     barrio,direccion)
                                     VALUES(cedula,primername,segundoname,primerape,segundoape,email,phone,city,barriocliente,direction);
  end;

--PAQUETES--


-->Paquete barrio
CREATE OR REPLACE PACKAGE PAQUETE_BARRIO
IS
    PROCEDURE GuardarBarrio(barrio in varchar2,lugar in number);
    PROCEDURE ConsultarBarrio(registro out SYS_REFCURSOR);
END;

CREATE OR REPLACE PACKAGE BODY PAQUETE_BARRIO
IS
    PROCEDURE GuardarBarrio(barrio in varchar2,lugar in number)
    AS
    BEGIN
        INSERT INTO Neigh(nombre,lugar_sk_lugar)
        VALUES(barrio,lugar);
    END GuardarBarrio;
    
    PROCEDURE ConsultarBarrio(registro out SYS_REFCURSOR)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM Neigh N
                          JOIN Place p 
                          ON(N.lugar_sk_lugar=p.sk_lugar);
    END ConsultarBarrio;
END;

-->Paquete lugar
CREATE OR REPLACE PACKAGE PAQUETE_LUGAR
IS
    PROCEDURE GuardarLugar(ciudadnew in varchar2);
    PROCEDURE ConsultarLugares(registro out SYS_refCURSOR);  
END;

CREATE OR REPLACE PACKAGE BODY PAQUETE_LUGAR
IS
    PROCEDURE GuardarLugar(ciudadnew in varchar2)
    AS
    BEGIN
        INSERT INTO Place(ciudad)
        VALUES(ciudadnew);
    END GuardarLugar;
    
    PROCEDURE ConsultarLugares(registro out SYS_refCURSOR)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM Place L JOIN
                          Neigh B 
                          ON(B.lugar_sk_lugar=sk_lugar);
    END ConsultarLugares;
END;

-->Paquete CUrso
CREATE OR REPLACE PACKAGE PAQUETE_CURSO
IS
    PROCEDURE GUARDARCURSOS(nombre in varchar2,estado in varchar2,fecha in varchar2,precio in numeric);
    PROCEDURE ConsultarCursos(registro out SYS_REFCURSOR);
    PROCEDURE BuscarCurso(registro out SYS_REFCURSOR, codigo in numeric);
    PROCEDURE MODIFICARCURSO(curso in number,precionew in number);
    PROCEDURE ELIMINARCURSO(curso in number);
END;

CREATE OR REPLACE PACKAGE BODY PAQUETE_CURSO
IS
    PROCEDURE GUARDARCURSOS(nombre in varchar2,estado in varchar2,fecha in varchar2,precio in numeric)
    AS
    BEGIN
        INSERT INTO Courses(nombre,estado,fecha,precio)
        VALUES(nombre,estado,fecha,precio);
    END;
    
    PROCEDURE ConsultarCursos(registro out SYS_REFCURSOR)
    AS
    BEGIN
        OPEN registro FOR SELECT * 
                          FROM Courses;
    END ConsultarCursos;
    
    PROCEDURE BuscarCurso(registro out SYS_REFCURSOR, codigo in numeric)
    AS
    BEGIN
        OPEN registro FOR SELECT *
                          FROM Courses
                          WHERE sk_curso=codigo;
    END BuscarCurso;

    PROCEDURE MODIFICARCURSO(curso in number,precionew in number)
    AS
    BEGIN
        UPDATE Courses SET precio=precionew
        WHERE sk_curso=curso;
    END MODIFICARCURSO;
    
    PROCEDURE ELIMINARCURSO(curso in number)
    AS
    BEGIN
        DELETE FROM Courses
        WHERE sk_curso=curso;
    END ELIMINARCURSO;
    
END;


-->Paquete producto
CREATE OR REPLACE PACKAGE PAQUETE_PRODUCTO
IS
    PROCEDURE GuardarProducto(producto in varchar2,nombre in varchar2,precio in number,marca in number);
    PROCEDURE ConsultarProductos(registro OUT SYS_REFCURSOR);
    PROCEDURE BuscarProducto(registro OUT SYS_REFCURSOR,codigo IN VARCHAR2);
    PROCEDURE ConsultarCodigo(registro OUT SYS_REFCURSOR,nombre IN VARCHAR2);
    PROCEDURE ModificarPrecioProductos(precionew IN NUMBER, codigo IN VARCHAR2);
    PROCEDURE EliminarProductos(codigo IN VARCHAR2);
END;

CREATE OR REPLACE PACKAGE BODY PAQUETE_PRODUCTO
IS
    PROCEDURE GuardarProducto(producto in varchar2,nombre in varchar2,precio in number,marca in number)
    AS
    BEGIN
        INSERT INTO Products(id_producto,nombre,precio,Marca_sk_marca)
        VALUES(producto,nombre,precio,marca);
    END GuardarProducto;
    
    PROCEDURE ConsultarProductos(registro OUT SYS_REFCURSOR)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM products p JOIN Brands m
                          ON(p.marca_sk_marca=m.sk_marca);
    END ConsultarProductos;
    
    PROCEDURE BuscarProducto(registro OUT SYS_REFCURSOR,codigo IN VARCHAR2)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM products p JOIN Brands m
                          ON(p.marca_sk_marca=m.sk_marca)
                          WHERE p.id_producto=codigo; 
    END BuscarProducto;
    
    PROCEDURE ConsultarCodigo(registro OUT SYS_REFCURSOR,nombre IN VARCHAR2)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM products p
                          WHERE p.nombre=nombre;
    END ConsultarCodigo;
    
    PROCEDURE ModificarPrecioProductos(precionew IN NUMBER, codigo IN VARCHAR2)
    AS
    BEGIN
        UPDATE Products SET precio=precionew
        WHERE id_producto=codigo;
    END ModificarPrecioProductos;
    
    PROCEDURE EliminarProductos(codigo IN VARCHAR2)
    AS
    BEGIN
        DELETE FROM Products
        WHERE id_producto=codigo;
    END EliminarProductos;

END;

-->Paquete Marca
CREATE OR REPLACE PACKAGE PAQUETE_MARCA
IS
    PROCEDURE GuardarMarcas(nombre in varchar2);
    PROCEDURE ConsultarMarcas(registro OUT SYS_REFCURSOR);
    PROCEDURE FiltrarMarcas(registro OUT SYS_REFCURSOR,nombre IN VARCHAR2);
    PROCEDURE CodigoNombreMarca(registro OUT SYS_REFCURSOR, nombre IN VARCHAR2);
    PROCEDURE ModificarMarca(marca in number, nombre in varchar2);
    PROCEDURE BuscarMarca(registro OUT SYS_REFCURSOR,marca in number);
    PROCEDURE EliminarMarca(marca in number);
END;

CREATE OR REPLACE PACKAGE BODY PAQUETE_MARCA
IS
    PROCEDURE GuardarMarcas(nombre in varchar2)
    AS
    BEGIN
        INSERT INTO Brands(nombremarca)
        VALUES(nombre);
    END GuardarMarcas;
    
    PROCEDURE ConsultarMarcas(registro OUT SYS_REFCURSOR)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM Brands;
    END ConsultarMarcas;
    
    PROCEDURE FiltrarMarcas(registro OUT SYS_REFCURSOR,nombre IN VARCHAR2)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM Brands WHERE nombremarca=nombre;
    END FiltrarMarcas;
    
    PROCEDURE CodigoNombreMarca(registro OUT SYS_REFCURSOR, nombre IN VARCHAR2)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM Brands 
                          WHERE nombremarca=nombre;
    END CodigoNombreMarca;
    
    PROCEDURE ModificarMarca(marca in number, nombre in varchar2)
    AS
    BEGIN
        UPDATE Brands SET nombremarca=nombre
        WHERE sk_marca=marca;
    END ModificarMarca;
    
    PROCEDURE BuscarMarca(registro OUT SYS_REFCURSOR,marca in number)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM Brands 
                          WHERE sk_marca=marca;
    END BuscarMarca;
    
    PROCEDURE EliminarMarca(marca in number)
    AS
    BEGIN
        DELETE FROM Brands
        WHERE sk_marca=marca;
    END EliminarMarca;
END;

