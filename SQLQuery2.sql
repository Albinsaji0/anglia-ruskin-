﻿create table vendor 
(
  id int primary key identity(1,1),
  vendor_id varchar(max) null,
  company_name varchar(max),
  company_website varchar (max),
  company_address varchar (max),
  software_name varchar(max),
  type_of_software varchar(max),
  image varchar(max),
  insert_date date null,
  update_date date null,
  delete_date date null


  )
  
  select * from vendor

  ALTER TABLE vendor
DROP COLUMN image;
