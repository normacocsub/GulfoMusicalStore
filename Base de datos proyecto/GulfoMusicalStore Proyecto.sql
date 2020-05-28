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

CREATE TABLE curso (
    sk_curso   NUMBER(3) NOT NULL,
    nombre     VARCHAR2(20),
    estado     VARCHAR2(20),
    fecha      DATE
);

ALTER TABLE curso ADD CONSTRAINT curso_pk PRIMARY KEY ( sk_curso );

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

--Sinonimos

CREATE PUBLIC SYNONYM Products FOR Producto;
CREATE PUBLIC SYNONYM Brands FOR Marca;

--Procedimientos productos.

CREATE OR REPLACE PROCEDURE GuardarProducto(producto in varchar2,nombre in varchar2,precio in number,marca in number)
AS
BEGIN
    INSERT INTO Products(id_producto,nombre,precio,Marca_sk_marca)
    VALUES(producto,nombre,precio,marca);
END;

CREATE OR REPLACE PROCEDURE ConsultarProductos(registro OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN registro FOR SELECT * FROM products p JOIN Brands m
                      ON(p.marca_sk_marca=m.sk_marca);
END;

CREATE OR REPLACE PROCEDURE BuscarProducto(registro OUT SYS_REFCURSOR,codigo IN VARCHAR2)
AS
BEGIN
    OPEN registro FOR SELECT * FROM products p JOIN Brands m
                      ON(p.marca_sk_marca=m.sk_marca)
                      WHERE p.id_producto=codigo; 
END;

CREATE OR REPLACE PROCEDURE ConsultarnombreCodigo(registro OUT SYS_REFCURSOR,nombre IN VARCHAR2)
AS
BEGIN
    OPEN registro FOR SELECT * FROM products p JOIN Brands m
                      ON(p.marca_sk_marca=m.sk_marca)
                      WHERE p.nombre=nombre;
END;

CREATE OR REPLACE PROCEDURE ModificarPrecioProductos(precionew IN NUMBER, codigo IN VARCHAR2)
AS
BEGIN
    UPDATE Products SET precio=precionew
    WHERE id_producto=codigo;
END;

CREATE OR REPLACE PROCEDURE EliminarProductos(codigo IN VARCHAR2)
AS
BEGIN
    DELETE FROM Products
    WHERE id_producto=codigo;
END;

--Procedimientos Marcas

CREATE OR REPLACE PROCEDURE GuardarMarcas(nombre in varchar2)
AS
BEGIN
    INSERT INTO Brands(nombremarca)
    VALUES(nombre);
END;

CREATE OR REPLACE PROCEDURE ConsultarMarcas(registro OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN registro FOR SELECT * FROM Brands;
END;

CREATE OR REPLACE PROCEDURE FiltrarMarcas(registro OUT SYS_REFCURSOR,nombre IN VARCHAR2)
AS
BEGIN
    OPEN registro FOR SELECT * FROM Brands WHERE nombremarca=nombre;
END;

--TRIGGERS MARCA
CREATE OR REPLACE TRIGGER MARCA_TRIGGER_SK_KEY
BEFORE INSERT ON Brands
FOR EACH ROW 
BEGIN
    SELECT SEQUENCE_MARCA.NEXTVAL
    INTO:NEW.sk_marca
    FROM DUAL;
END;

