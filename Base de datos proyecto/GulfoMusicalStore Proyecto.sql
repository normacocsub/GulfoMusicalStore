CREATE TABLE barrio (
    sk_barrio        NUMBER(3) NOT NULL,
    nombre           VARCHAR2(20) NOT NULL,
    lugar_sk_lugar   NUMBER(3) NOT NULL
);

ALTER TABLE barrio ADD CONSTRAINT barrio_pk PRIMARY KEY ( sk_barrio );



CREATE TABLE cliente (
    id_clientte       VARCHAR2(12) NOT NULL,
    primernombre      VARCHAR2(20) NOT NULL,
    segundonombre     VARCHAR2(20),
    primerapellido    VARCHAR2(20) NOT NULL,
    segundoapellido   VARCHAR2(20),
    correo            VARCHAR2(50),
    telefono          VARCHAR2(10),
    direccion         VARCHAR2(30),
    lugar_sk_lugar    NUMBER(3) NOT NULL,
    Barrio varchar2(20)
);

ALTER TABLE cliente ADD CONSTRAINT cliente_pk PRIMARY KEY ( id_clientte );
CREATE TABLE curso (
    sk_curso   NUMBER(3) NOT NULL,
    nombre     VARCHAR2(20),
    estado     VARCHAR2(20),
    fecha      DATE
);

ALTER TABLE curso ADD CONSTRAINT curso_pk PRIMARY KEY ( sk_curso );
ALTER TABLE curso ADD Precio number(8,2);
ALTER TABLE curso modify fecha varchar2(15);
ALTER TABLE curso add sk_curso varchar2(5);
ALter table curso_Factura modify curso_Sk_curso varchar2(5);

CREATE TABLE curso_factura (
    factura_factura_id    NUMBER NOT NULL,
    curso_sk_curso        NUMBER(3) NOT NULL,
    precio                NUMBER(8, 2) NOT NULL,
    fecha                 DATE,
    cliente_id_clientte   VARCHAR2(12) NOT NULL
);

ALTER TABLE curso_factura ADD CONSTRAINT curso_factura_pk PRIMARY KEY ( factura_factura_id,
                                                                        cliente_id_clientte );
ALTER TABLE curso_factura ADD Cantidad number(2);
ALTER TABLE curso_factura modify fecha varchar2(27);


CREATE TABLE factura (
    sk_factura   NUMBER(3) NOT NULL,
    fecha        DATE,
    estado       VARCHAR2(10) DEFAULT 'ACTIVO',
    subtotal     NUMBER(8, 2),
    iva          NUMBER(8, 2),
    total        NUMBER(10, 2),
    cantidad     NUMBER(2)
);

ALTER TABLE factura ADD CONSTRAINT factura_pk PRIMARY KEY ( sk_factura );
ALTER TABLE factura modify subTotal number(12,2);
ALTER TABLE factura modify iva number(12,2);
ALTER TABLE factura modify total number(12,2);
ALTER TABLE factura add cliente_id_clientte varchar2(12);
ALTER TABLE factura modify fecha varchar2(27);
ALTER TABLE factura add CiudadFactura varchar2(20);

CREATE TABLE lugar (
    sk_lugar   NUMBER(3) NOT NULL,
    ciudad     VARCHAR2(20)
);

ALTER TABLE lugar ADD CONSTRAINT lugar_pk PRIMARY KEY ( sk_lugar );

CREATE TABLE marca (
    sk_marca   NUMBER(3) NOT NULL,
    nombremarca     VARCHAR2(20) NOT NULL
);

ALTER TABLE marca ADD CONSTRAINT marca_pk PRIMARY KEY ( sk_marca );
ALTER TABLE marca modify  sk_marca varchar2(5);
ALter table producto modify marca_sk_marca varchar2(5);

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
ALTER TABLE product_factura modify fecha varchar2(27);

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


ALTER TABLE cliente
    ADD CONSTRAINT cliente_lugar_fk FOREIGN KEY ( lugar_sk_lugar )
        REFERENCES lugar ( sk_lugar );
        
ALTER TABLE factura
    ADD CONSTRAINT factura_cliente_fk FOREIGN KEY ( cliente_id_clientte )
        REFERENCES cliente ( id_clientte );


ALTER TABLE curso_factura
    ADD CONSTRAINT curso_factura_cliente_fk FOREIGN KEY ( cliente_id_clientte )
        REFERENCES cliente ( id_clientte );

ALTER TABLE curso_factura ADD curso_sk_curso number(3);
select * from curso_factura;
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
        
ALTER TABLE Factura add ciudadfactura varchar2(20);
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
ALTER TABLE RegistroUsuarios ADD Tabla varchar2(20);

--Alter table RegistroUsuarios Add CiudadRegistro varchar2(20);

CREATE TABLE ESTADISTICAS(sk_estadistica number(3),total number(12,2),unidades number(3));
ALTER TABLE Estadisticas ADD CONSTRAINT estadistica_pk PRIMARY KEY ( sk_estadistica );
ALTER TABLE Estadisticas ADD fecha  varchar2(25);


--SECUENCIAS
delete from product_factura;
delete from curso_factura;
delete from factura;
delete from estadisticas;
delete from registrousuarios;
ALter table estadisticas add factura_sk_factura number(3);

ALTER TABLE estadisticas
    ADD CONSTRAINT estadisticas_factura_fk FOREIGN KEY ( factura_Sk_factura )
        REFERENCES factura ( sk_factura );

CREATE SEQUENCE LUGAR_SEQUENCIA INCREMENT BY 1 START WITH 1 MAXVALUE 9999 MINVALUE 1 CACHE 20 ORDER;
CREATE SEQUENCE FACTURA_SEQUENCIA INCREMENT BY 1 START WITH 1 MAXVALUE 9999 MINVALUE 1 CACHE 20 ORDER;
CREATE SEQUENCE Estadisticas_SEQUENCIA INCREMENT BY 1 START WITH 1 MAXVALUE 9999 MINVALUE 1 CACHE 20 ORDER;
CREATE SEQUENCE SEQUENCE_Usuarios INCREMENT BY 1 START WITH 1 MAXVALUE 9999 MINVALUE 1;
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




--TRIGERS Conexion REMOTA;

CREATE OR REPLACE TRIGGER LUGAR_TRIGGER_Conection_Remote
AFTER INSERT ON Lugar
FOR EACH ROW
BEGIN
    INSERT INTO gulfocali.Lugar@Gulfo_Bogo_Cali(ciudad)
    VALUES(:new.ciudad);
END;

CREATE OR REPLACE TRIGGER Conexion_Marca_Remote_Cali
AFTER INSERT OR UPDATE ON Gulfo.Marca
FOR EACH ROW
Declare 
idCali marca.sk_marca%type;
BEGIN
    if INSERTING THEN
    INSERT INTO gulfocali.marca@Gulfo_Bogo_Cali(sk_marca,nombremarca)
    VALUES(:new.sk_marca,:new.nombremarca);
    END IF;

    IF UPDATING THEN
    UPDATE gulfocali.marca@Gulfo_Bogo_Cali
    SET nombremarca=:new.nombremarca
    WHERE sk_marca=:new.sk_marca;
    END IF;
END;

CREATE OR REPLACE TRIGGER Conexion_Marca_Remote_Barra
AFTER INSERT OR UPDATE ON Gulfo.Marca
FOR EACH ROW
BEGIN
    if INSERTING THEN
    INSERT INTO gulfobarra.marca@Gulfo_Bogo_Barra(sk_marca,nombremarca)
    VALUES(:new.sk_marca,:new.nombremarca);
    END IF;
    IF UPDATING THEN
    UPDATE gulfobarra.marca@Gulfo_Bogo_Barra
    SET nombremarca=:new.nombremarca
    WHERE sk_marca=:new.sk_marca;
    END IF;
END;

CREATE OR REPLACE TRIGGER Conexion_Producto_Remote_Cali
AFTER INSERT OR UPDATE ON gulfo.Producto
FOR EACH ROW
BEGIN
    IF INSERTING THEN 
        INSERT INTO GulfoCali.Producto@Gulfo_Bogo_Cali(id_producto,nombre,precio,marca_sk_marca)
        VALUES(:new.id_producto,:new.nombre,:new.precio,:new.marca_sk_marca);
    END IF;
    IF UPDATING THEN
        UPDATE GulfoCali.Producto@Gulfo_Bogo_Cali
        SET nombre=:new.nombre,precio=:new.precio
        WHERE id_producto=:new.id_producto;
    END IF;
END;

CREATE OR REPLACE TRIGGER Conexion_Producto_Remote_Barra
AFTER INSERT OR UPDATE ON gulfo.Producto
FOR EACH ROW
BEGIN
    IF INSERTING THEN 
        INSERT INTO gulfobarra.producto@Gulfo_Bogo_Barra(id_producto,nombre,precio,marca_sk_marca)
        VALUES(:new.id_producto,:new.nombre,:new.precio,:new.marca_sk_marca);
    END IF;
    IF UPDATING THEN
        UPDATE gulfobarra.producto@Gulfo_Bogo_Barra
        SET nombre=:new.nombre,precio=:new.precio
        WHERE id_producto=:new.id_producto;
    END IF;
END;

CREATE OR REPLACE TRIGGER Conexion_Curso_Remote_Cali
AFTER INSERT OR UPDATE ON gulfo.Curso
FOR EACH ROW
BEGIN
    IF INSERTING THEN
        INSERT INTO gulfocali.curso@Gulfo_Bogo_Cali(sk_curso,nombre,estado,fecha,precio)
        VALUES(:new.sk_curso,:new.nombre,:new.estado,:new.fecha,:new.precio);
    END IF;
    IF UPDATING THEN
        UPDATE gulfocali.curso@Gulfo_Bogo_Cali
        SET Nombre=:new.nombre, estado=:new.estado,precio=:new.precio
        WHERE sk_curso=:new.sk_curso;
    END IF;
END;

CREATE OR REPLACE TRIGGER Conexion_Curso_Remote_Barra
AFTER INSERT OR UPDATE ON gulfo.Curso
FOR EACH ROW
BEGIN
    IF INSERTING THEN
        INSERT INTO gulfoBarra.curso@Gulfo_Bogo_Barra(sk_curso,nombre,estado,fecha,precio)
        VALUES(:new.sk_curso,:new.nombre,:new.estado,:new.fecha,:new.precio);
    END IF;
    IF UPDATING THEN
        UPDATE gulfoBarra.curso@Gulfo_Bogo_Barra
        SET Nombre=:new.nombre, estado=:new.estado,precio=:new.precio
        WHERE sk_curso=:new.sk_curso;
    END IF;
END;



rollback;
select * from marca;
INSERT INTO marca(sk_marca,nombremarca)
VALUES('Sp','Space');




--TRIGGERS LUGAR

CREATE OR REPLACE TRIGGER SEQUENCIA_TRIGGER_LUGAR
BEFORE INSERT ON Lugar
FOR EACH ROW
BEGIN
    SELECT LUGAR_SEQUENCIA.NEXTVAL
    INTO:NEW.sk_lugar
    FROM DUAL;
END SEQUENCIA_TRIGGER_LUGAR;




--TRIGERS FACTURA

CREATE OR REPLACE TRIGGER factura_trigger
BEFORE INSERT ON FACTURA
FOR EACH ROW
BEGIN
    SELECT FACTURA_SEQUENCIA.NEXTVAL
    INTO:NEW.sk_Factura
    FROM dual;
    INSERT INTO Factura_tmp VALUES(:NEW.sk_factura);
END factura_trigger;

--TRIGGERS ESTADISTICAS

CREATE OR REPLACE TRIGGER estadistica_trigger
BEFORE INSERT ON Factura
FOR EACH ROW
DECLARE
    fecha estadisticas.fecha%type;
BEGIN
    SELECT TO_CHAR (SYSDATE, 'DD-MM-YYYY HH24:MI:SS') INTO fecha FROM DUAL;
    INSERT INTO estadisticas(sk_estadistica,TOtal,unidades,fecha,factura_sk_factura)
    VALUES(Estadisticas_SEQUENCIA.NEXTVAL,:new.total,:new.cantidad,fecha,:new.sk_factura);
END estadistica_trigger;



--TRIGGER ACTIVIDAD USUARIOS

CREATE OR REPLACE TRIGGER SEQUENCE_TRIGGER_USERS
BEFORE INSERT ON RegistroUsuarios
FOR EACH ROW
BEGIN
    SELECT SEQUENCE_Usuarios.nextval
    INTO:new.sk_usuario
    FROM DUAL;
END SEQUENCE_TRIGGER_USERS;

CREATE OR REPLACE TRIGGER REGISTRO_BARRIOS_TRIGGER
AFTER INSERT OR UPDATE OR DELETE ON Barrio
FOR EACH ROW
declare accion registrousuarios.accion%type;
        tabla registrousuarios.tabla%type:='Barrio';
BEGIN
    if INSERTING THEN
        accion:='INSERT';
    end if;
    if UPDATING THEN
        accion:='UPDATE';
    end if;
    if DELETING THEN
        accion:='DELETE';
    end if;
    INSERT_REGISTROUSUARIO(accion,tabla);
END REGISTRO_BARRIOS_TRIGGER;

CREATE OR REPLACE TRIGGER REGISTRO_CLIENTES_TRIGGER
AFTER INSERT OR UPDATE OR DELETE ON Cliente
FOR EACH ROW
declare accion registrousuarios.accion%type;
        tabla registrousuarios.tabla%type:='Cliente';
BEGIN
    IF INSERTING THEN
        accion:='INSERT';
    END IF;
    IF UPDATING THEN
        accion:='UPDATE';
    END IF;
    IF DELETING THEN
        accion:='DELETE';
    END IF; 
    INSERT_REGISTROUSUARIO(accion,tabla);
END REGISTRO_CLIENTES_TRIGGER;

CREATE OR REPLACE TRIGGER REGISTRO_CURSOS_TRIGGER
AFTER UPDATE OR INSERT OR DELETE ON Curso
FOR EACH ROW
declare accion registrousuarios.accion%type;
        tabla registrousuarios.tabla%type:='Curso';
BEGIN
    IF INSERTING THEN
        accion:='INSERT';
    END IF;
    IF UPDATING THEN
        accion:='UPDATE';
    END IF;
    IF DELETING THEN
        accion:='DELETE';
    END IF;
    INSERT_REGISTROUSUARIO(accion,tabla);
END REGISTRO_CURSOS_TRIGGER;

CREATE OR REPLACE TRIGGER REGISTRO_FACTURAS_TRIGGER
AFTER UPDATE OR INSERT OR DELETE ON Factura
FOR EACH ROW
declare accion registrousuarios.accion%type;
        tabla registrousuarios.tabla%type:='Factura';
BEGIN
    IF INSERTING THEN
        accion:='INSERT';
    END IF;
    IF UPDATING THEN
        accion:='UPDATE';
    END IF;
    IF DELETING THEN
        accion:='DELETE';
    END IF;
    INSERT_REGISTROUSUARIO(accion,tabla);
END REGISTRO_FACTURAS_TRIGGER;

CREATE OR REPLACE TRIGGER REGISTRO_LUGARES_TRIGGER
AFTER UPDATE OR INSERT OR DELETE ON Lugar
FOR EACH ROW
declare accion registrousuarios.accion%type:='UPDATE';
        tabla registrousuarios.tabla%type:='Lugar';
BEGIN
    IF INSERTING THEN
        accion:='INSERT';
    END IF;
    IF UPDATING THEN
        accion:='UPDATE';
    END IF;
    IF DELETING THEN
        accion:='DELETE';
    END IF;
    INSERT_REGISTROUSUARIO(accion,tabla);
END REGISTRO_LUGARES_TRIGGER;

CREATE OR REPLACE TRIGGER REGISTRO_MARCAS_TRIGGER
AFTER UPDATE OR INSERT OR DELETE ON Marca
FOR EACH ROW
declare accion registrousuarios.accion%type:='UPDATE';
        tabla registrousuarios.tabla%type:='Marca';
BEGIN
    IF INSERTING THEN
        accion:='INSERT';
    END IF;
    IF UPDATING THEN
        accion:='UPDATE';
    END IF;
    IF DELETING THEN
        accion:='DELETE';
    END IF;
    INSERT_REGISTROUSUARIO(accion,tabla);
END REGISTRO_MARCAS_TRIGGER;


CREATE OR REPLACE TRIGGER REGISTRO_PRODUCTOS_TRIGGER
AFTER UPDATE OR INSERT OR DELETE ON Producto
FOR EACH ROW
declare accion registrousuarios.accion%type:='UPDATE';
        tabla registrousuarios.tabla%type:='Producto';
BEGIN
    IF INSERTING THEN
        accion:='INSERT';
    END IF;
    IF UPDATING THEN
        accion:='UPDATE';
    END IF;
    IF DELETING THEN
        accion:='DELETE';
    END IF;
    INSERT_REGISTROUSUARIO(accion,tabla);
END REGISTRO_PRODUCTOS_TRIGGER;


--PROCEDIMIENTO PARA TRIGGGER
CREATE OR REPLACE PROCEDURE INSERT_REGISTROUSUARIO(x_accion in varchar2,x_tabla in varchar2)
AS
ip_pc RegistroUsuarios.ip_pc%type;
nombre_pc RegistroUsuarios.nombre_pc%type;
hora registrousuarios.hora%type;
BEGIN
    
    select SYS_CONTEXT('USERENV', 'IP_ADDRESS') INTO ip_pc from dual;
    select sys_context('userenv','os_user') INTO nombre_pc FROM DUAL;
    SELECT TO_CHAR (SYSDATE, 'HH24:MI:SS') INTO hora FROM DUAL;
    INSERT INTO RegistroUsuarios(usuario,ip_pc,nombre_pc,fecha,accion,hora,tabla)
    VALUES(user,ip_pc,nombre_pc,sysdate,x_accion,hora,x_tabla);
END INSERT_REGISTROUSUARIO;








--PAQUETES--



-->Paquete DetalleProducto
CREATE OR REPLACE PACKAGE PAQUETE_ESTADISTICAS
IS
    PROCEDURE FILTRARESTADISTICAS(estadisticas OUT SYS_REFCURSOR);
    PROCEDURE FiltrarEstadisticasCiudad(estadisticas out sys_Refcursor,codigociudad in number);
END PAQUETE_ESTADISTICAS;

CREATE OR REPLACE PACKAGE BODY PAQUETE_ESTADISTICAS
IS
    PROCEDURE FILTRARESTADISTICAS(estadisticas OUT SYS_REFCURSOR)
    AS
    BEGIN
        OPEN estadisticas FOR SELECT * FROM ESTADISTICAS;
    END FILTRARESTADISTICAS;
    
    PROCEDURE FiltrarEstadisticasCiudad(estadisticas out sys_Refcursor,codigociudad in number)
    AS
    BEGIN
        OPEN estadisticas FOR SELECT * FROM estadisticas e JOIN Factura f
                              ON(e.factura_Sk_factura=f.sk_Factura)
                              JOIN lugar l ON(f.lugar_sk_lugar=l.sk_lugar)
                              WHERE l.sk_lugar=codigociudad;
    END FiltrarEstadisticasCiudad;
END PAQUETE_ESTADISTICAS;

CREATE OR REPLACE PACKAGE PAQUETE_Detalles
IS
    PROCEDURE GuardarDetalleFactura(precio in number, fechadate in varchar2, factura in varchar2,cantidad in number, producto in varchar2, cliente in number);
    PROCEDURE GuardarDetalleCurso(precio in number, fechadate in varchar2, factura in varchar2,cantidad in number, curso in varchar2, cliente in number);
    PROCEDURE ConsultarDetalleProducto(detalles out SYS_REFCURSOR,d_factura in varchar2);
    PROCEDURE ConsultarDetalleCurso(detalles out SYS_REFCURSOR,d_factura in varchar2);
END PAQUETE_Detalles;


CREATE OR REPLACE PACKAGE BODY PAQUETE_Detalles
IS
    PROCEDURE GuardarDetalleFactura(precio in number, fechadate in varchar2, factura in varchar2,cantidad in number, producto in varchar2, cliente in number)
    AS
    BEGIN
        INSERT INTO Product_Factura(preciodetalle,fecha,factura_factura_id,cantidad,producto_id_producto,cliente_id_clientte)
        VALUES(precio,fechadate,factura,cantidad,producto,cliente);
    END GuardarDetalleFactura;
    
    PROCEDURE GuardarDetalleCurso(precio in number, fechadate in varchar2, factura in varchar2,cantidad in number, curso in varchar2, cliente in number)
    AS
    BEGIN
        INSERT INTO Curso_Factura(preciodetalle,fecha,factura_factura_id,cantidad,curso_Sk_curso,cliente_id_Clientte)
        VALUES(precio,fechadate,factura,cantidad,curso,cliente);
    END GuardarDetalleCurso;
    
    PROCEDURE ConsultarDetalleProducto(detalles out SYS_REFCURSOR,d_factura in varchar2)
    AS
    BEGIN
        OPEN detalles FOR SELECT * FROM Product_Factura P JOIN Producto pr
                                        ON(p.producto_id_producto=pr.id_producto)
                                        Join Marca m
                                        ON(pr.marca_sk_marca=m.sk_marca)
                          WHERE factura_factura_id=d_factura;
    END ConsultarDetalleProducto;
    
    PROCEDURE ConsultarDetalleCurso(detalles out SYS_REFCURSOR,d_factura in varchar2)
    AS
    BEGIN
        OPEN detalles FOR select * from curso_factura cf JOIN curso c
                          on(cf.curso_sk_curso=c.sk_curso)
                          WHERE factura_factura_id=d_factura;
    END ConsultarDetalleCurso;
END PAQUETE_Detalles;

-->Paquete factura

CREATE OR REPLACE PACKAGE PAQUETE_FACTURA
IS
    procedure GuardarFacturas(codigo in varchar2,fecha in varchar2, estadofac varchar2, subtotalfac in number, ivafac in number, totalfac in number,
                                            cantidadfac in number,x_id_cliente in varchar2,x_CiudadFactura in number);
    PROCEDURE OBTENERCODIGOFACTURA(factura out SYS_REFCURSOR);
    
    PROCEDURE EliminarTablaTemporal;
    
    PROCEDURE ConsultarFacturas(facturas OUT SYS_REFCURSOR);
    
    PROCEDURE FILTRARFACTURASESTADO(facturas OUT SYS_REFCURSOR, f_estado in varchar2);
    
    PROCEDURE FILTRARFACTURACEDULA(facturas OUT SYS_REFCURSOR,f_cedula in varchar2);
    
    PROCEDURE BUSCARFACTURA(facturas OUT SYS_REFCURSOR,f_factura in varchar2);
    
    PROCEDURE FILTRONUMEROFACTURALIKE(facturas OUT SYS_REFCURSOR, f_factura in varchar2);
    
    PROCEDURE ACTUALIZARFACTURA(f_factura in varchar2, f_Estado in varchar2);
    
    PROCEDURE FILTRARCiudadFactura(facturas out sys_Refcursor,codigociudad in number);
    
    PROCEDURE FILTROTOTALASC(Facturas out sys_Refcursor);
    
    PROCEDURE FILTROTOTALDES(facturas out sys_refcursor);
END PAQUETE_FACTURA;

CREATE OR REPLACE PACKAGE BODY PAQUETE_FACTURA
IS
    PROCEDURE GuardarFacturas(codigo in varchar2,fecha in varchar2, estadofac varchar2, subtotalfac in number, ivafac in number, totalfac in number,
                              cantidadfac in number,x_id_cliente in varchar2, x_CiudadFactura in number)
    AS
    BEGIN 
        INSERT INTO FACTURA(sk_factura,fecha,estado,subtotal,iva,total,cantidad,cliente_id_clientte,lugar_sk_lugar)
        VALUES(codigo,fecha,estadofac,subtotalfac,ivafac,totalfac,cantidadfac,x_id_cliente,x_CiudadFactura);
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
    
    
    PROCEDURE ConsultarFacturas(facturas OUT SYS_REFCURSOR)
    AS
    BEGIN
        OPEN facturas FOR SELECT * FROM Factura F
                          JOIN CLIENTE c
                          ON(c.id_clientte=f.CLIENTE_id_clientte)
                          JOIN Lugar l
                          ON(f.lugar_sk_lugar=l.sk_lugar)
                          ORDER BY f.sk_factura;
    END ConsultarFacturas;
    
    PROCEDURE FILTRARFACTURASESTADO(facturas OUT SYS_REFCURSOR, f_estado in varchar2)
    AS
    BEGIN
        OPEN facturas FOR SELECT * FROM Factura F
                          JOIN CLIENTE c
                          ON(c.id_clientte=f.CLIENTE_id_clientte)
                          JOIN lugar l
                          ON(f.lugar_sk_lugar=l.sk_lugar)
                          WHERE F.estado=f_estado
                          ORDER BY F.sk_factura;
    END FILTRARFACTURASESTADO;
    
    PROCEDURE FILTRARFACTURACEDULA(facturas OUT SYS_REFCURSOR,f_cedula in varchar2)
    AS
    BEGIN
        OPEN facturas FOR SELECT * FROM Factura F
                          JOIN CLIENTE c
                          ON(c.id_clientte=f.CLIENTE_id_clientte)
                          JOIN lugar l
                          ON(f.lugar_sk_lugar=l.sk_lugar)
                          WHERE F.cliente_id_clientte=f_cedula
                          ORDER BY F.sk_factura;
    END FILTRARFACTURACEDULA;
    
    PROCEDURE BUSCARFACTURA(facturas OUT SYS_REFCURSOR,f_factura in varchar2)
    AS
    BEGIN
        OPEN facturas FOR SELECT * FROM Factura F
                          JOIN CLIENTE c
                          ON(c.id_clientte=f.CLIENTE_id_clientte)
                          JOIN lugar l
                          ON(f.lugar_sk_lugar=l.sk_lugar)
                          WHERE F.sk_Factura=f_factura; 
    END BUSCARFACTURA;
    
    PROCEDURE FILTRONUMEROFACTURALIKE(facturas OUT SYS_REFCURSOR, f_factura in varchar2)
    AS
    BEGIN
        OPEN facturas FOR SELECT * FROM Factura F
                          JOIN CLIENTE c
                          ON(c.id_clientte=f.CLIENTE_id_clientte)
                          JOIN lugar l
                          ON(f.lugar_sk_lugar=l.sk_lugar)
                          WHERE F.sk_Factura like f_factura;
    END FILTRONUMEROFACTURALIKE;
    
    PROCEDURE ACTUALIZARFACTURA(f_factura in varchar2, f_Estado in varchar2)
    AS
    BEGIN
        UPDATE Factura
        SET estado=f_Estado
        WHERE sk_factura=f_factura;
    END ACTUALIZARFACTURA;
    
    PROCEDURE FILTRARCiudadFactura(facturas out sys_Refcursor,codigociudad in number)
    AS
    BEGIN
        Open facturas FOR select * from factura f join lugar l
                          on(f.lugar_sk_lugar=l.sk_lugar)
                          JOIN cliente c ON(f.cliente_id_clientte=id_clientte)
                          WHERE l.sk_lugar=codigociudad;
    END FILTRARCiudadFactura;
    
    PROCEDURE FILTROTOTALASC(Facturas out sys_Refcursor)
    AS
    BEGIN
        OPEN facturas FOR select * from factura f JOIN lugar l
                          on(f.lugar_sk_lugar=l.sk_lugar)
                          JOIN cliente c ON(f.cliente_id_clientte=c.id_clientte)
                          ORDER BY Total ASC;
    END FILTROTOTALASC;
    
    PROCEDURE FILTROTOTALDES(facturas out sys_refcursor)
    AS
    BEGIN
        OPEN facturas FOR select * from factura f JOIN lugar l
                          on(f.lugar_sk_lugar=l.sk_lugar)
                          JOIN cliente c ON(f.cliente_id_clientte=c.id_clientte)
                          ORDER BY Total DESC;
    END FILTROTOTALDES;
END PAQUETE_FACTURA;


-->Paquete cliente
CREATE OR REPLACE PACKAGE PAQUETE_CLIIENTE
IS
    PROCEDURE GuardarCLientes(cedula in VARCHAR2,primername in varchar2, segundoname in varchar2, primerape in varchar2,
                              segundoape in varchar2,  email in varchar2, phone in varchar2,
                              city in number, barriocliente in varchar2, direction in varchar2);
    
    PROCEDURE BuscarCliente(registro out SYS_REFCURSOR, cedula in varchar2);
    
    PROCEDURE ConsultarClientes(registro out SYS_REFCURSOR);
    
    PROCEDURE ModificarClientes(cedula in VARCHAR2,primername in varchar2, segundoname in varchar2, primerape in varchar2,
                                segundoape in varchar2,  email in varchar2, phone in varchar2,
                                city in number, barriocliente in varchar2, direction in varchar2);
    
    PROCEDURE FILTRARCEDULACLIENTES(clientes OUT SYS_REFCURSOR, c_cedula in varchar2);
    
    PROCEDURE FILTRARPRIMERNOMBRECLIENTES(clientes OUT SYS_REFCURSOR, c_primernombre in varchar2);
    
END PAQUETE_CLIIENTE;

 
CREATE OR REPLACE PACKAGE BODY PAQUETE_CLIIENTE
IS
        PROCEDURE GuardarCLientes(cedula in VARCHAR2,primername in varchar2, segundoname in varchar2, primerape in varchar2,
                                              segundoape in varchar2,  email in varchar2, phone in varchar2,
                                              city in number, barriocliente in varchar2, direction in varchar2)
        AS
        BEGIN
            INSERT INTO cliente(id_clientte,primernombre,segundonombre,primerapellido,segundoapellido,correo,telefono,lugar_sk_lugar,
                                     barrio_sk_barrio,direccion)
                                     VALUES(cedula,primername,segundoname,primerape,segundoape,email,phone,city,barriocliente,direction);
        END GuardarCLientes;
        
        PROCEDURE BuscarCliente(registro out SYS_REFCURSOR, cedula in varchar2)
        AS
        BEGIN
            OPEN registro FOR SELECT * FROM CLiente  c JOIN lugar p
                              ON(c.lugar_sk_lugar=p.sk_lugar)
                              JOIN barrio N
                              ON(c.barrio_sk_barrio=N.sk_barrio)
                              WHERE id_clientte=cedula;
        END BuscarCliente;
        
        PROCEDURE ConsultarClientes(registro out SYS_REFCURSOR)
        AS
        BEGIN
            OPEN registro FOR SELECT * 
            FROM cliente c JOIN lugar p
            ON(c.lugar_sk_lugar=p.sk_lugar)
            JOIN barrio N
            ON(c.barrio_sk_barrio=N.sk_barrio);
        END ConsultarClientes;
        
        PROCEDURE ModificarClientes(cedula in VARCHAR2,primername in varchar2, segundoname in varchar2, primerape in varchar2,
                                              segundoape in varchar2, email in varchar2, phone in varchar2,
                                              city in number, barriocliente in varchar2, direction in varchar2)
                                              
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
            UPDATE cliente SET PrimerNombre=VPrName,SegundoNombre=VSgName,PrimerApellido=VPrApe, SegundoAPellido=VSgApe,
                                   Correo=VEmail, Telefono=VPhone, lugar_sk_lugar=VCity, Barrio_sk_barrio=VBarrio, Direccion=VDirection
                               WHERE id_clientte= VCedula;
        END ModificarClientes;
        
        PROCEDURE FILTRARCEDULACLIENTES(clientes OUT SYS_REFCURSOR, c_cedula in varchar2)
        AS
        BEGIN
            OPEN clientes FOR select * from cliente c
                              JOIN Lugar l
                              ON(l.sk_lugar=c.lugar_sk_lugar)
                              JOIN Barrio b
                              ON(b.sk_barrio=barrio_sk_barrio)
                              WHERE c.id_clientte like c_cedula;
                              
        END FILTRARCEDULACLIENTES;
        
        PROCEDURE FILTRARPRIMERNOMBRECLIENTES(clientes OUT SYS_REFCURSOR, c_primernombre in varchar2)
        AS
        BEGIN
            OPEN clientes FOR select * from cliente c
                              JOIN Lugar l
                              ON(l.sk_lugar=c.lugar_sk_lugar)
                              JOIN Barrio b
                              ON(b.sk_barrio=barrio_sk_barrio)
                              WHERE c.primernombre like c_primernombre;
        END FILTRARPRIMERNOMBRECLIENTES;
        
END PAQUETE_CLIIENTE;
 
-->Paquete barrio
CREATE OR REPLACE PACKAGE PAQUETE_BARRIO
IS
    PROCEDURE GuardarBarrio(barrio in varchar2,lugar in number);
    PROCEDURE ConsultarBarrio(registro out SYS_REFCURSOR);
END PAQUETE_BARRIO;

CREATE OR REPLACE PACKAGE BODY PAQUETE_BARRIO
IS
    PROCEDURE GuardarBarrio(barrio in varchar2,lugar in number)
    AS
    BEGIN
        INSERT INTO Barrio(nombre,lugar_sk_lugar)
        VALUES(barrio,lugar);
    END GuardarBarrio;
    
    PROCEDURE ConsultarBarrio(registro out SYS_REFCURSOR)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM Barrio N
                          JOIN Lugar p 
                          ON(N.lugar_sk_lugar=p.sk_lugar);
    END ConsultarBarrio;
END PAQUETE_BARRIO;

-->Paquete lugar
CREATE OR REPLACE PACKAGE PAQUETE_LUGAR
IS
    PROCEDURE GuardarLugar(ciudadnew in varchar2);
    PROCEDURE ConsultarLugares(registro out SYS_refCURSOR);  
END PAQUETE_LUGAR;

CREATE OR REPLACE PACKAGE BODY PAQUETE_LUGAR
IS
    PROCEDURE GuardarLugar(ciudadnew in varchar2)
    AS
    BEGIN
        INSERT INTO lugar(ciudad)
        VALUES(ciudadnew);
    END GuardarLugar;
    
    PROCEDURE ConsultarLugares(registro out SYS_refCURSOR)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM lugar L JOIN
                          barrio B 
                          ON(B.lugar_sk_lugar=sk_lugar);
    END ConsultarLugares;
END PAQUETE_LUGAR;

-->Paquete CUrso
CREATE OR REPLACE PACKAGE PAQUETE_CURSO
IS
    PROCEDURE GUARDARCURSOS(x_sk_curso in varchar2,nombre in varchar2,estado in varchar2,fecha in varchar2,precio in numeric);
    PROCEDURE ConsultarCursos(registro out SYS_REFCURSOR);
    PROCEDURE BuscarCurso(registro out SYS_REFCURSOR, codigo in varchar2);
    PROCEDURE MODIFICARCURSO(curso in varchar2,precionew in number,estadonew in varchar2,nombrenew in varchar2);
    PROCEDURE ELIMINARCURSO(curso in varchar2);
    PROCEDURE FILTRARESTADOCURSO(cursos OUT SYS_REFCURSOR,c_estado in varchar2);
END PAQUETE_CURSO;

CREATE OR REPLACE PACKAGE BODY PAQUETE_CURSO
IS
    PROCEDURE GUARDARCURSOS(x_sk_curso in varchar2,nombre in varchar2,estado in varchar2,fecha in varchar2,precio in numeric)
    AS
    BEGIN
        INSERT INTO Curso(sk_curso,nombre,estado,fecha,precio)
        VALUES(x_sk_curso,nombre,estado,fecha,precio);
    END;
    
    PROCEDURE ConsultarCursos(registro out SYS_REFCURSOR)
    AS
    BEGIN
        OPEN registro FOR SELECT * 
                          FROM Curso;
    END ConsultarCursos;
    
    PROCEDURE BuscarCurso(registro out SYS_REFCURSOR, codigo in varchar2)
    AS
    BEGIN
        OPEN registro FOR SELECT *
                          FROM Curso
                          WHERE sk_curso=codigo;
    END BuscarCurso;

    PROCEDURE MODIFICARCURSO(curso in varchar2,precionew in number,estadonew in varchar2,nombrenew in varchar2)
    AS
    BEGIN
        UPDATE Curso SET precio=precionew,estado=estadonew, nombre=nombrenew
        WHERE sk_curso=curso;
    END MODIFICARCURSO;
    
    PROCEDURE ELIMINARCURSO(curso in varchar2)
    AS
    BEGIN
        DELETE FROM Curso
        WHERE sk_curso=curso;
    END ELIMINARCURSO;
    
    PROCEDURE FILTRARESTADOCURSO(cursos OUT SYS_REFCURSOR,c_estado in varchar2)
    AS
    BEGIN
        OPEN cursos FOR SELECT *
                          FROM Curso
                          WHERE estado=c_estado;
    END FILTRARESTADOCURSO;
END PAQUETE_CURSO;


-->Paquete producto
CREATE OR REPLACE PACKAGE PAQUETE_PRODUCTO
IS
    PROCEDURE GuardarProducto(producto in varchar2,nombre in varchar2,precio in number,marca in varchar2);
    PROCEDURE ConsultarProductos(registro OUT SYS_REFCURSOR);
    PROCEDURE BuscarProducto(registro OUT SYS_REFCURSOR,codigo IN VARCHAR2);
    PROCEDURE ConsultarCodigo(registro OUT SYS_REFCURSOR,nombre IN VARCHAR2);
    PROCEDURE ModificarPrecioProductos(precionew IN NUMBER, codigo IN VARCHAR2,nombrenew in varchar2);
    PROCEDURE EliminarProductos(codigo IN VARCHAR2);
    PROCEDURE FILTRARPRODUCTOSMARCA(productos OUT SYS_REFCURSOR,p_sk_marca in varchar2);
END PAQUETE_PRODUCTO;

CREATE OR REPLACE PACKAGE BODY PAQUETE_PRODUCTO
IS
    PROCEDURE GuardarProducto(producto in varchar2,nombre in varchar2,precio in number,marca in varchar2)
    AS
    BEGIN
        INSERT INTO Producto(id_producto,nombre,precio,Marca_sk_marca)
        VALUES(producto,nombre,precio,marca);
    END GuardarProducto;
    
    PROCEDURE ConsultarProductos(registro OUT SYS_REFCURSOR)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM Producto p JOIN Marca m
                          ON(p.marca_sk_marca=m.sk_marca);
    END ConsultarProductos;
    
    PROCEDURE BuscarProducto(registro OUT SYS_REFCURSOR,codigo IN VARCHAR2)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM Producto p JOIN Marca m
                          ON(p.marca_sk_marca=m.sk_marca)
                          WHERE p.id_producto=codigo; 
    END BuscarProducto;
    
    PROCEDURE ConsultarCodigo(registro OUT SYS_REFCURSOR,nombre IN VARCHAR2)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM Producto p
                          WHERE p.nombre=nombre;
    END ConsultarCodigo;
    
    PROCEDURE ModificarPrecioProductos(precionew IN NUMBER, codigo IN VARCHAR2,nombrenew in varchar2)
    AS
    BEGIN
        UPDATE Producto SET precio=precionew,nombre=nombrenew
        WHERE id_producto=codigo;
    END ModificarPrecioProductos;
    
    PROCEDURE EliminarProductos(codigo IN VARCHAR2)
    AS
    BEGIN
        DELETE FROM Producto
        WHERE id_producto=codigo;
    END EliminarProductos;

    PROCEDURE FILTRARPRODUCTOSMARCA(productos OUT SYS_REFCURSOR,p_sk_marca in varchar2)
    AS
    BEGIN
        OPEN productos FOR SELECT * FROM Producto p JOIN Marca m
                          ON(p.marca_sk_marca=m.sk_marca)
                          WHERE m.sk_marca=p_sk_marca;
    END FILTRARPRODUCTOSMARCA;
END PAQUETE_PRODUCTO;


-->Paquete Marca
CREATE OR REPLACE PACKAGE PAQUETE_MARCA
IS
    PROCEDURE GuardarMarcas(m_sk_marca in varchar2,nombre in varchar2);
    PROCEDURE ConsultarMarcas(registro OUT SYS_REFCURSOR);
    PROCEDURE FiltrarMarcas(registro OUT SYS_REFCURSOR,nombre IN VARCHAR2);
    PROCEDURE CodigoNombreMarca(registro OUT SYS_REFCURSOR, nombre IN VARCHAR2);
    PROCEDURE ModificarMarca(marca in varchar2, nombre in varchar2);
    PROCEDURE BuscarMarca(registro OUT SYS_REFCURSOR,marca in varchar2);
    PROCEDURE EliminarMarca(marca in varchar2);
END PAQUETE_MARCA;

CREATE OR REPLACE PACKAGE BODY PAQUETE_MARCA
IS
    PROCEDURE GuardarMarcas(m_sk_marca in varchar2,nombre in varchar2)
    AS
    BEGIN
        INSERT INTO Marca(sk_marca,nombremarca)
        VALUES(m_sk_marca,nombre);
    END GuardarMarcas;
    
    PROCEDURE ConsultarMarcas(registro OUT SYS_REFCURSOR)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM Marca;
    END ConsultarMarcas;
    
    PROCEDURE FiltrarMarcas(registro OUT SYS_REFCURSOR,nombre IN VARCHAR2)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM Marca WHERE nombremarca=nombre;
    END FiltrarMarcas;
    
    PROCEDURE CodigoNombreMarca(registro OUT SYS_REFCURSOR, nombre IN VARCHAR2)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM Marca 
                          WHERE nombremarca=nombre;
    END CodigoNombreMarca;
    
    PROCEDURE ModificarMarca(marca in varchar2, nombre in varchar2)
    AS
    BEGIN
        UPDATE Marca SET nombremarca=nombre
        WHERE sk_marca=marca;
    END ModificarMarca;
    
    PROCEDURE BuscarMarca(registro OUT SYS_REFCURSOR,marca in varchar2)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM Marca 
                          WHERE sk_marca=marca;
    END BuscarMarca;
    
    PROCEDURE EliminarMarca(marca in varchar2)
    AS
    BEGIN
        DELETE FROM Marca
        WHERE sk_marca=marca;
    END EliminarMarca;
END PAQUETE_MARCA;




