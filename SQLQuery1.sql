use DBcontacts

select * from Contact
where ID = 1


create procedure ReadContact @ID int as
begin
select * from contact 
where ID = @ID
end 
go

execute ReadContact 3



select * from contact

create procedure ReadAllContact as
begin
select * from Contact
end 


execute ReadAllContact


insert into Contact 
values
('1970484-45463','Pedro', 'Costas')

create procedure cretecontact2 @ssn varchar (12), @fn varchar (32), @ln varchar (32)  as
begin
insert into Contact
values(@ssn,@fn,@ln)


end

