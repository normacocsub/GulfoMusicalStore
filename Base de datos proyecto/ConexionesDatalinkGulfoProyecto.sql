create database link Gulfo_Cali_Bogo connect to gulfo identified by Shoops0119 using 'localhost:1521/xe'; 
create database link Gulfo_Bogo_Cali connect to GulfoCali identified by Shoops0119 using 'localhost:1521/xe';
create database link Gulfo_Bogo_Barra connect to GulfoBarra identified by Shoops0119 using 'localhost:1521/xe';
create database link Gulfo_Barra_Bogo connect to gulfo identified by Shoops0119 using 'localhost:1521/xe';
create database link Gulfo_Cali_Barra connect to gulfoBarra identified by Shoops0119 using 'localhost:1521/xe';


