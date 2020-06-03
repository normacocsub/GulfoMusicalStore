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
ALTER TABLE curso_factura ADD Cantidad number(2);

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
ALTER TABLE factura modify subTotal number(12,2);
ALTER TABLE factura modify iva number(12,2);
ALTER TABLE factura modify total number(12,2);

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
ALTER TABLE product_factura ADD Cantidad number(2);

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
CREATE SEQUENCE FACTURA_SEQUENCIA INCREMENT BY 1 START WITH 1 MAXVALUE 9999 MINVALUE 1 CACHE 20 ORDER;
CREATE SEQUENCE Detalleproducto_SEQUENCIA INCREMENT BY 1 START WITH 1 MAXVALUE 9999 MINVALUE 1 CACHE 20 ORDER;
CREATE SEQUENCE DetalleCurso_SEQUENCIA INCREMENT BY 1 START WITH 1 MAXVALUE 9999 MINVALUE 1 CACHE 20 ORDER;
CREATE SEQUENCE Estadisticas_SEQUENCIA INCREMENT BY 1 START WITH 1 MAXVALUE 9999 MINVALUE 1 CACHE 20 ORDER;
CREATE SEQUENCE SEQUENCE_Usuarios INCREMENT BY 1 START WITH 1 MAXVALUE 100 MINVALUE 1;
--Sinonimos

CREATE PUBLIC SYNONYM Products FOR Producto;
CREATE PUBLIC SYNONYM Brands FOR Marca;
CREATE PUBLIC SYNONYM Courses FOR Curso;
CREATE PUBLIC SYNONYM Place FOR lugar;
CREATE PUBLIC SYNONYM Neigh FOR Barrio;
CREATE PUBLIC SYNONYM Clients FOR CLiente;
CREATE PUBLIC SYNONYM Bill FOR FACTURA;
CREATE PUBLIC SYNONYM ProductoFactura FOR Product_Factura;
CREATE PUBLIC SYNONYM CursoFactura FOR Curso_Factura;
CREATE PUBLIC SYNONYM STATICTS FOR Estadisticas;

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


--TRIGERS FACTURA

CREATE OR REPLACE TRIGGER factura_trigger
BEFORE INSERT ON FACTURA
FOR EACH ROW
BEGIN
    SELECT FACTURA_SEQUENCIA.NEXTVAL
    INTO:NEW.sk_Factura
    FROM dual;
    INSERT INTO Factura_tmp VALUES(:NEW.sk_factura);
END;

--TRIGGERS ESTADISTICAS

CREATE OR REPLACE TRIGGER estadistica_trigger
BEFORE INSERT ON Factura
FOR EACH ROW
DECLARE
    fecha estadisticas.fecha%type;
BEGIN
    SELECT TO_CHAR (SYSDATE, 'DD-MM-YYYY HH24:MI:SS') INTO fecha FROM DUAL;
    INSERT INTO STATICTS(sk_estadistica,TOtal,unidades,fecha)
    VALUES(Estadisticas_SEQUENCIA.NEXTVAL,:new.total,:new.cantidad,fecha);
END;



--TRIGGER ACTIVIDAD USUARIOS

CREATE OR REPLACE TRIGGER SEQUENCE_TRIGGER_USERS
BEFORE INSERT ON RegistroUsuarios
FOR EACH ROW
BEGIN
    SELECT SEQUENCE_Usuarios.nextval
    INTO:new.sk_usuario
    FROM DUAL;
END;

CREATE OR REPLACE TRIGGER REGISTRO_BARRIO_TRIGGER
AFTER INSERT ON Barrio
FOR EACH ROW
declare accion registrousuarios.accion%type:='INSERT';
BEGIN
    INSERT_REGISTROUSUARIO(accion);
END;

CREATE OR REPLACE TRIGGER REGISTRO_BARRIO2_TRIGGER
AFTER UPDATE ON Barrio
FOR EACH ROW
declare accion registrousuarios.accion%type:='UPDATE';
BEGIN
    INSERT_REGISTROUSUARIO(accion);
END;

CREATE OR REPLACE TRIGGER REGISTRO_CLIENTE_TRIGGER
AFTER INSERT ON Cliente
FOR EACH ROW
declare accion registrousuarios.accion%type:='INSERT';
BEGIN
    INSERT_REGISTROUSUARIO(accion);
END;

CREATE OR REPLACE TRIGGER REGISTRO_Cliente2_TRIGGER
AFTER UPDATE ON Cliente
FOR EACH ROW
declare accion registrousuarios.accion%type:='UPDATE';
BEGIN
    INSERT_REGISTROUSUARIO(accion);
END;

CREATE OR REPLACE TRIGGER REGISTRO_CURSO_TRIGGER
AFTER UPDATE ON Curso
FOR EACH ROW
declare accion registrousuarios.accion%type:='UPDATE';
BEGIN
    INSERT_REGISTROUSUARIO(accion);
END;

CREATE OR REPLACE TRIGGER REGISTRO_Curso2_TRIGGER
AFTER INSERT ON Curso
FOR EACH ROW
declare accion registrousuarios.accion%type:='INSERT';
BEGIN
    INSERT_REGISTROUSUARIO(accion);
END;

CREATE OR REPLACE TRIGGER REGISTRO_Curso3_TRIGGER
AFTER DELETE ON Curso
FOR EACH ROW
declare accion registrousuarios.accion%type:='DELETE';
BEGIN
    INSERT_REGISTROUSUARIO(accion);
END;

CREATE OR REPLACE TRIGGER REGISTRO_Factura_TRIGGER
AFTER UPDATE ON Factura
FOR EACH ROW
declare accion registrousuarios.accion%type:='UPDATE';
BEGIN
    INSERT_REGISTROUSUARIO(accion);
END;

CREATE OR REPLACE TRIGGER REGISTRO_Factura2_TRIGGER
AFTER INSERT ON Factura
FOR EACH ROW
declare accion registrousuarios.accion%type:='INSERT';
BEGIN
    INSERT_REGISTROUSUARIO(accion);
END;

CREATE OR REPLACE TRIGGER REGISTRO_LUGAR_TRIGGER
AFTER UPDATE ON Lugar
FOR EACH ROW
declare accion registrousuarios.accion%type:='UPDATE';
BEGIN
    INSERT_REGISTROUSUARIO(accion);
END;

CREATE OR REPLACE TRIGGER REGISTRO_Lugar2_TRIGGER
AFTER INSERT ON Lugar
FOR EACH ROW
declare accion registrousuarios.accion%type:='INSERT';
BEGIN
    INSERT_REGISTROUSUARIO(accion);
END;

CREATE OR REPLACE TRIGGER REGISTRO_LUGAR3_TRIGGER
AFTER DELETE ON Lugar
FOR EACH ROW
declare accion registrousuarios.accion%type:='DELETE';
BEGIN
    INSERT_REGISTROUSUARIO(accion);
END;

CREATE OR REPLACE TRIGGER REGISTRO_MARCA_TRIGGER
AFTER UPDATE ON Marca
FOR EACH ROW
declare accion registrousuarios.accion%type:='UPDATE';
BEGIN
    INSERT_REGISTROUSUARIO(accion);
END;

CREATE OR REPLACE TRIGGER REGISTRO_Marca2_TRIGGER
AFTER INSERT ON Marca
FOR EACH ROW
declare accion registrousuarios.accion%type:='INSERT';
BEGIN
    INSERT_REGISTROUSUARIO(accion);
END;

CREATE OR REPLACE TRIGGER REGISTRO_MARCA3_TRIGGER
AFTER DELETE ON Marca
FOR EACH ROW
declare accion registrousuarios.accion%type:='DELETE';
BEGIN
    INSERT_REGISTROUSUARIO(accion);
END;

CREATE OR REPLACE TRIGGER REGISTRO_PRODUCTO_TRIGGER
AFTER UPDATE ON Producto
FOR EACH ROW
declare accion registrousuarios.accion%type:='UPDATE';
BEGIN
    INSERT_REGISTROUSUARIO(accion);
END;

CREATE OR REPLACE TRIGGER REGISTRO_Producto2_TRIGGER
AFTER INSERT ON producto
FOR EACH ROW
declare accion registrousuarios.accion%type:='INSERT';
BEGIN
    INSERT_REGISTROUSUARIO(accion);
END;

CREATE OR REPLACE TRIGGER REGISTRO_Producto3_TRIGGER
AFTER DELETE ON producto
FOR EACH ROW
declare accion registrousuarios.accion%type:='DELETE';
BEGIN
    INSERT_REGISTROUSUARIO(accion);
END;


--PROCEDIMIENTO PARA TRIGGGER
CREATE OR REPLACE PROCEDURE INSERT_REGISTROUSUARIO(accion in varchar2)
AS
ip_pc RegistroUsuarios.ip_pc%type;
nombre_pc RegistroUsuarios.nombre_pc%type;
hora registrousuarios.hora%type;
BEGIN
    
    select SYS_CONTEXT('USERENV', 'IP_ADDRESS') INTO ip_pc from dual;
    select sys_context('userenv','os_user') INTO nombre_pc FROM DUAL;
    SELECT TO_CHAR (SYSDATE, 'HH24:MI:SS') INTO hora FROM DUAL;
    INSERT INTO RegistroUsuarios(usuario,ip_pc,nombre_pc,fecha,accion,hora)
    VALUES(user,ip_pc,nombre_pc,sysdate,accion,hora);
END;



--tablas del esquema sin relacion

CREATE TABLE Factura_tmp(sk_codigo  number(3));
CREATE TABLE RegistroUsuarios(sk_usuario number(2),
                              usuario varchar2(15),
                              ip_pc varchar2(25),
                              nombre_pc varchar2(15)
                              , fecha varchar2(10),
                              Accion varchar2(15),
                              hora varchar2(20));
                              
ALTER TABLE RegistroUsuarios ADD CONSTRAINT RegistroUsuarios_pk PRIMARY KEY ( sk_usuario);




CREATE TABLE ESTADISTICAS(sk_estadistica number(3),total number(12,2),unidades number(3));
ALTER TABLE Estadisticas ADD CONSTRAINT estadistica_pk PRIMARY KEY ( sk_estadistica );
ALTER TABLE Estadisticas ADD fecha  varchar2(25);




--PAQUETES--



-->Paquete DetalleProducto

CREATE OR REPLACE PACKAGE PAQUETE_Detalles
IS
    PROCEDURE GuardarDetalleFactura(precio in number, fechadate in date, factura in number,cantidad in number, producto in varchar2, cliente in number);
    PROCEDURE GuardarDetalleCurso(precio in number, fechadate in date, factura in number,cantidad in number, curso in number, cliente in number);
END;


CREATE OR REPLACE PACKAGE BODY PAQUETE_Detalles
IS
    PROCEDURE GuardarDetalleFactura(precio in number, fechadate in date, factura in number,cantidad in number, producto in varchar2, cliente in number)
    AS
    BEGIN
        INSERT INTO ProductoFactura(precio,fecha,factura_factura_id,cantidad,producto_id_producto,cliente_id_clientte)
        VALUES(precio,fechadate,factura,cantidad,producto,cliente);
    END GuardarDetalleFactura;
    
    PROCEDURE GuardarDetalleCurso(precio in number, fechadate in date, factura in number,cantidad in number, curso in number, cliente in number)
    AS
    BEGIN
        INSERT INTO CursoFactura(precio,fecha,factura_factura_id,cantidad,curso_Sk_curso,cliente_id_Clientte)
        VALUES(precio,fechadate,factura,cantidad,curso,cliente);
    END GuardarDetalleCurso;
END;

-->Paquete factura

CREATE OR REPLACE PACKAGE PAQUETE_FACTURA
IS
    procedure GuardarFacturas(fecha in date, estadofac varchar2, subtotalfac in number, ivafac in number, totalfac in number,
                                            cantidadfac in number);
    PROCEDURE OBTENERCODIGOFACTURA(factura out SYS_REFCURSOR);
    
    PROCEDURE EliminarTablaTemporal;
END;

CREATE OR REPLACE PACKAGE BODY PAQUETE_FACTURA
IS
    PROCEDURE GuardarFacturas(fecha in date, estadofac varchar2, subtotalfac in number, ivafac in number, totalfac in number,
                              cantidadfac in number)
    AS
    BEGIN 
        INSERT INTO FACTURA(fecha,estado,subtotal,iva,total,cantidad)
        VALUES(fecha,estadofac,subtotalfac,ivafac,totalfac,cantidadfac);
    END GuardarFacturas;
    
    PROCEDURE OBTENERCODIGOFACTURA(factura out SYS_REFCURSOR)
    AS
    BEGIN
        OPEN factura FOR SELECT *  FROM Factura_TMP;
    END OBTENERCODIGOFACTURA;
    
    PROCEDURE EliminarTablaTemporal
    AS
    BEGIN
        DELETE FROM FACTURA_TMP;
    END EliminarTablaTemporal;
END;

-->Paquete cliente
CREATE OR REPLACE PACKAGE PAQUETE_CLIIENTE
IS
    PROCEDURE GuardarCLientes(cedula in VARCHAR2,primername in varchar2, segundoname in varchar2, primerape in varchar2,
                              segundoape in varchar2,  email in varchar2, phone in varchar2,
                              city in number, barriocliente in number, direction in varchar2);
    
    PROCEDURE BuscarCliente(registro out SYS_REFCURSOR, cedula in varchar2);
    
    PROCEDURE ConsultarClientes(registro out SYS_REFCURSOR);
    
    PROCEDURE ModificarClientes(cedula in VARCHAR2,primername in varchar2, segundoname in varchar2, primerape in varchar2,
                                segundoape in varchar2,  email in varchar2, phone in varchar2,
                                city in number, barriocliente in number, direction in varchar2);
END;

 
CREATE OR REPLACE PACKAGE BODY PAQUETE_CLIIENTE
IS
        PROCEDURE GuardarCLientes(cedula in VARCHAR2,primername in varchar2, segundoname in varchar2, primerape in varchar2,
                                              segundoape in varchar2,  email in varchar2, phone in varchar2,
                                              city in number, barriocliente in number, direction in varchar2)
        AS
        BEGIN
            INSERT INTO clients(id_clientte,primernombre,segundonombre,primerapellido,segundoapellido,correo,telefono,lugar_sk_lugar,
                                     barrio_sk_barrio,direccion)
                                     VALUES(cedula,primername,segundoname,primerape,segundoape,email,phone,city,barriocliente,direction);
        END GuardarCLientes;
        
        PROCEDURE BuscarCliente(registro out SYS_REFCURSOR, cedula in varchar2)
        AS
        BEGIN
            OPEN registro FOR SELECT * FROM CLients  c JOIN PLace p
                              ON(c.lugar_sk_lugar=p.sk_lugar)
                              JOIN Neigh N
                              ON(c.barrio_sk_barrio=N.sk_barrio)
                              WHERE id_clientte=cedula;
        END BuscarCliente;
        
        PROCEDURE ConsultarClientes(registro out SYS_REFCURSOR)
        AS
        BEGIN
            OPEN registro FOR SELECT * 
            FROM clients c JOIN PLace p
            ON(c.lugar_sk_lugar=p.sk_lugar)
            JOIN Neigh N
            ON(c.barrio_sk_barrio=N.sk_barrio);
        END ConsultarClientes;
        
        PROCEDURE ModificarClientes(cedula in VARCHAR2,primername in varchar2, segundoname in varchar2, primerape in varchar2,
                                              segundoape in varchar2, email in varchar2, phone in varchar2,
                                              city in number, barriocliente in number, direction in varchar2)
                                              
        AS
            VCedula  varchar2(12):=cedula;
            VPrName  varchar2(15):=primername;
            VSgName varchar2(15):=segundoname;
            VPrApe varchar2(15):=primerape;
            VSgApe varchar2(15):=segundoape;
            VEmail varchar2(30):=email;
            VPhone varchar2(10):=phone;
            VCity NUMBER(15):=city;
            VBarrio number(15):=barriocliente;
            VDirection varchar(30):=direction;
        BEGIN
            UPDATE clients SET PrimerNombre=VPrName,SegundoNombre=VSgName,PrimerApellido=VPrApe, SegundoAPellido=VSgApe,
                                   Correo=VEmail, Telefono=VPhone, lugar_sk_lugar=VCity, Barrio_sk_barrio=VBarrio, Direccion=VDirection
                               WHERE id_clientte= VCedula;
        END ModificarClientes;
END;
 
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

select * from clients;
