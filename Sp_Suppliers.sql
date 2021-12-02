
select  * from suppliers

Select CompanyName from Suppliers where SupplierID = 1


Select * from Suppliers where SupplierID like 1

Create  Proc Sp_Suppliers
@SupplierID INT OUTPUT, 
@CompanyName VARCHAR(40), 
@ContactName varchar(30),
@ContactTitle varchar(30),
@Address varchar(60),
@City varchar (15),
@Region varchar (15),
@PostalCode varchar(10),
@Country varchar(15),
@Phone Varchar(24),
@Fax varchar (24),
@Homepage varchar(60) as
begin if exists (Select * from Suppliers where SupplierID = @SupplierID)
	begin
		UPDATE Suppliers set 
		CompanyName = @CompanyName, 
		ContactName = @ContactName, 
		ContactTitle = @ContactTitle,
		Address = @Address,
		City =  @City,
		Region = @Region,
		PostalCode = @PostalCode,
		Country = @Country,
		Phone = @Phone,
		Fax = @Fax,
		HomePage = @Homepage
		where SupplierID = @SupplierID
		
		if @@Error <> 0
		Begin	
			RaisError('Error al Actualizar en la tabla Suppliers',16,10)
		end
	end
	ELSE
	BEGIN
	--Si la llave primaria no es identity, se busca la ultima clave mas uno
	Select @SupplierID = coalesce(Max(SupplierID),0) + 1 from Suppliers
	Insert Suppliers (CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage) 
	values (@CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax, @Homepage)
	
	if @@Error <>0
	Begin
		RaisError('Error al actualizar en la tabla Suppliers',16,10)
	end
	select @SupplierID = @@Identity
	end
	end
