CREATE TABLE Productos(id_producto varchar2(4) primary key, nombreproducto varchar(20) not null, modeloproducto varchar(15), precio number(8,2) not null, id_marca varchar(4) not null);
CREATE SEQUENCE PRODUCTS_SEQUENCIA INCREMENT BY 1 START WITH 1 MAXVALUE 1000 MINVALUE 1;

create or replace trigger products_trigger
before insert on Productos
for each row
begin
select products_sequencia.NEXTVAL
into: new.id_producto
from dual;
end;

create or replace procedure GuardarProductos(nombre in varchar2,modelo in varchar2, precio in number, marca in varchar2)
as
begin
insert into normataller.productos(nombreproducto,modeloproducto,precio,id_marca) VALUES(nombre,modelo,precio,marca);
end;

--actualizar consulta con detalles.
create or replace  procedure contarproductos(registro out SYS_REFCURSOR, nombreproduct in varchar2)
as
begin
  open registro for select count(*) from normataller.productos where nombreproducto=nombreproduct;
  end;
  
  
  --actualizar consulta con detalles.
  create or replace  procedure ConsultarProductos(registro out SYS_REFCURSOr)
  as
  begin
  open registro for select * from normataller.productos p join marca m
  ON(m.id_marca=p.id_marca);
  end;
  
  --actualizar consulta con detalles
  create or replace  procedure filtrarproductos(registros out SYS_REFCURSOR,nombreproduct in varchar2)
  as
  begin
     open registros for select * from normataller.productos where nombreproducto=nombreproduct;
     end;
     
     