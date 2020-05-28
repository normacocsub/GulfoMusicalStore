 CREATE TABLE CLIENTES(id_cliente varchar2(12) primary key, primernombre varchar2(15) not null, segundonombre varchar2(15), primerapellido varchar2(15)
                      not null, segundoapellido varchar2(15), genero varchar2(1) not null, correo varchar2(30) not null, telefono varchar2(10) not null,
                      ciudad varchar2(15) not null, barrio varchar2(15) not null, direccion varchar2(30) not null);
                      


  create or replace procedure BuscarCliente(registro out SYS_REFCURSOR, cedula in varchar2)
  as
  begin
  open registro for SELECT * FROM normataller.clientes where id_cliente=cedula;
  end;
  
  create or replace procedure ConsultarClientes(registro out SYS_REFCURSOR)
  as
  begin
  open registro for SELECT * FROM normataller.clientes;
  end;
  
  create or replace procedure GuardarCLientes(cedula in VARCHAR2,primername in varchar2, segundoname in varchar2, primerape in varchar2,
                                              segundoape in varchar2, sexo in varchar2, email in varchar2, phone in varchar2,
                                              city in varchar2, barriocliente in varchar2, direction in varchar2)
  as
  begin
    insert into normataller.clientes(id_cliente,primernombre,segundonombre,primerapellido,segundoapellido,genero,correo,telefono,ciudad,
                                     barrio,direccion)
                                     VALUES(cedula,primername,segundoname,primerape,segundoape,sexo,email,phone,city,barriocliente,direction);
  end;
  
  create or replace procedure ModificarClientes(cedula in VARCHAR2,primername in varchar2, segundoname in varchar2, primerape in varchar2,
                                              segundoape in varchar2, sexo in varchar2, email in varchar2, phone in varchar2,
                                              city in varchar2, barriocliente in varchar2, direction in varchar2)
                                              
 as
 VCedula  varchar2(12):=cedula;
 VPrName  varchar2(15):=primername;
 VSgName varchar2(15):=segundoname;
 VPrApe varchar2(15):=primerape;
 VSgApe varchar2(15):=segundoape;
 VSexo varchar2(1):=sexo;
 VEmail varchar2(30):=email;
 VPhone varchar2(10):=phone;
 VCity varchar(15):=city;
 VBarrio varchar(15):=barriocliente;
 VDirection varchar(30):=direction;
 begin
   update normataller.clientes set PrimerNombre=VPrName,SegundoNombre=VSgName,PrimerApellido=VPrApe, SegundoAPellido=VSgApe,Genero=VSexo,
                                   Correo=VEmail, Telefono=VPhone, Ciudad=VCity, Barrio=VBarrio, Direccion=VDirection
                               Where id_cliente= VCedula;
end ModificarClientes;
   
   
   SELECT * FROM CLientes;