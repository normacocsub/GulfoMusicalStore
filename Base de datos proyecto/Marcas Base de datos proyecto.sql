CREATE TABLE Marca(id_marca varchar2(4) PRIMARY KEY, nombremarca varchar2(15) not null, fechacreacion date not null);
DROP TABLE MARCA;

CREATE SEQUENCE marca_sequencia INCREMENT BY 1 START WITH 1 MAXVALUE 100 MINVALUE 1;

create or replace trigger marca_trigger
before insert on Marca
for each row
begin
select marca_sequencia.NEXTVAL
into: new.id_marca
from dual;
end;

create or replace procedure GuardarMarcas(nombre in varchar2,fecha in date)
as
begin
insert into normataller.Marca(nombremarca,fechacreacion) VALUES(nombre,fecha);
end;

create or replace procedure ConsultarMarcas(registro out SYS_REFCURSOR)
as
begin
open registro for select * from normataller.marca;
end;

create or replace procedure FiltrarMarcas(registro out SYS_REFCURSOR,nombre varchar2)
as 
begin
open registro for select * from normataller.marca where nombremarca=nombre;
end;


