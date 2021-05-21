create table Code (
	id int primary key identity,
	name_code varchar(200)
)

create table CodeDetails(
	id int primary key identity,
	Price_TC float ,
	Price_Tran float,
	Price_San float,
	G3_Buy float,
	KL3_Buy decimal,
	G2_Buy float,
	KL2_Buy decimal,
	G1_Buy float,
	KL1_Buy decimal,
	Price_OrderExecution float,
	KL_OrderExecution decimal,
	G1_Sell float,
	KL1_Sell decimal,
	G2_Sell float,
	KL2_Sell decimal,
	G3_Sell float,
	KL3_Sell decimal,
	TotalKL decimal,
	OpenDoor float,
	Tallest float,
	Lowest float,
	NNBuy float,
	NNSell float,
	Room_Left decimal
)

create table Users(
	Id int primary key identity,
	Name nvarchar(200),
	Email nvarchar(200),
	Password varchar(100),
	Temppass varchar(100)
)

select * from Code
select * from CodeDetails
select * from Users

-- CRUD code (ma chung khoan)
insert into Code(name_code) values ('BID')

update Code set name_code = 'BVH' where id = 1

delete from Code where id = 1

select * from Code where id = 1

-- CRUD code details (chi tiet ma chung khoan)
insert into CodeDetails(Price_TC,Price_Tran,Price_San,G3_Buy,KL3_Buy,G2_Buy,KL2_Buy,G1_Buy,KL1_Buy,Price_OrderExecution,
	KL_OrderExecution,G1_Sell,KL1_Sell,G2_Sell,KL2_Sell,G3_Sell,KL3_Sell,TotalKL,OpenDoor,Tallest,Lowest,NNBuy,NNSell,Room_Left)
values (42.95,45.95,39.95,43.35,1000,43.4,44900,43.45,22900,43.45,8000,43.5,88200,43.55,16100,43.6,154600,2100300,43,43.7,43,9500,118000,520148141)

update CodeDetails set Price_TC = 43.95 , Price_Tran = 123,Price_San= 123,G3_Buy = 1231,KL3_Buy = 1234,G2_Buy=123,KL2_Buy=123,G1_Buy=123,KL1_Buy=11,Price_OrderExecution=12123,
KL_OrderExecution = 111,G1_Sell=123,KL1_Sell=123,G2_Sell=123312,KL2_Sell=1123,G3_Sell=0123,KL3_Sell=67,TotalKL=33252895,OpenDoor = 34,Tallest = 14,Lowest= 12,NNBuy= 13244,NNSell = 3564,Room_Left = 12498239 where id = 1

delete from CodeDetails where id = 1

select * from CodeDetails where id = 1

-- CRUD user
insert into Users(Name,Email,Password,Temppass) values ('Nong','nong@gmail.com','nongne21','user12345')

update Users set Name = 'Long' , Email = 'long@gmail.com',Password = 'longday'  where id = 1

delete from Users where id = 1

select * from CodeDetails where id = 1

-- Join = fulljoin  inner join
select Code.name_code ,CodeDetails.G1_Buy from Code full outer join CodeDetails on Code.id_details = CodeDetails.id 

-- Join = inner join
select Code.name_code ,CodeDetails.G1_Buy,CodeDetails.G1_Sell,CodeDetails.G2_Buy,CodeDetails.G2_Sell,CodeDetails.G3_Buy,CodeDetails.G3_Sell,CodeDetails.KL_OrderExecution,
CodeDetails.KL1_Buy,CodeDetails.KL1_Sell,CodeDetails.KL2_Buy,CodeDetails.KL2_Sell,CodeDetails.KL3_Buy,CodeDetails.KL3_Sell
,CodeDetails.Lowest,CodeDetails.NNBuy,CodeDetails.NNSell,CodeDetails.OpenDoor,CodeDetails.Price_OrderExecution,CodeDetails.Price_San,CodeDetails.Price_TC
,CodeDetails.Price_Tran,CodeDetails.Room_Left,CodeDetails.Tallest,CodeDetails.TotalKL from Code inner join CodeDetails on Code.id_details = CodeDetails.id

--View getPriceList
alter view getPriceList 
as
select Code.name_code ,CodeDetails.G1_Buy,CodeDetails.G1_Sell,CodeDetails.G2_Buy,CodeDetails.G2_Sell,CodeDetails.G3_Buy,CodeDetails.G3_Sell,CodeDetails.KL_OrderExecution,
CodeDetails.KL1_Buy,CodeDetails.KL1_Sell,CodeDetails.KL2_Buy,CodeDetails.KL2_Sell,CodeDetails.KL3_Buy,CodeDetails.KL3_Sell
,CodeDetails.Lowest,CodeDetails.NNBuy,CodeDetails.NNSell,CodeDetails.OpenDoor,CodeDetails.Price_OrderExecution,CodeDetails.Price_San,CodeDetails.Price_TC
,CodeDetails.Price_Tran,CodeDetails.Room_Left,CodeDetails.Tallest,CodeDetails.TotalKL from Code inner join CodeDetails on Code.id_details = CodeDetails.id

select * from getPriceList

-- View User
create view getListUser
as
select * from Users
-- get user by id 
create view getListUserById
as
select * from Users where id = Id


-- SP CRUD Code DETAILS (CHI TIET ma chung khoan)
-- Get code
create proc SP_GetPiceList
AS
	begin try
		select Code.name_code ,CodeDetails.G1_Buy,CodeDetails.G1_Sell,CodeDetails.G2_Buy,CodeDetails.G2_Sell,CodeDetails.G3_Buy,CodeDetails.G3_Sell,CodeDetails.KL_OrderExecution,
		CodeDetails.KL1_Buy,CodeDetails.KL1_Sell,CodeDetails.KL2_Buy,CodeDetails.KL2_Sell,CodeDetails.KL3_Buy,CodeDetails.KL3_Sell
		,CodeDetails.Lowest,CodeDetails.NNBuy,CodeDetails.NNSell,CodeDetails.OpenDoor,CodeDetails.Price_OrderExecution,CodeDetails.Price_San,CodeDetails.Price_TC
		,CodeDetails.Price_Tran,CodeDetails.Room_Left,CodeDetails.Tallest,CodeDetails.TotalKL from Code inner join CodeDetails on Code.id = CodeDetails.id
	end try
	begin catch
		select
			ERROR_NUMBER() AS ErrorNumber,  
			ERROR_MESSAGE() AS ErrorMessage,
			ERROR_LINE()AS ErrorLine
	end catch

-- Get COde By id
create proc SP_GetPiceListById
@ID int
AS
	begin try
		select Code.name_code ,CodeDetails.G1_Buy,CodeDetails.G1_Sell,CodeDetails.G2_Buy,CodeDetails.G2_Sell,CodeDetails.G3_Buy,CodeDetails.G3_Sell,CodeDetails.KL_OrderExecution,
		CodeDetails.KL1_Buy,CodeDetails.KL1_Sell,CodeDetails.KL2_Buy,CodeDetails.KL2_Sell,CodeDetails.KL3_Buy,CodeDetails.KL3_Sell
		,CodeDetails.Lowest,CodeDetails.NNBuy,CodeDetails.NNSell,CodeDetails.OpenDoor,CodeDetails.Price_OrderExecution,CodeDetails.Price_San,CodeDetails.Price_TC
		,CodeDetails.Price_Tran,CodeDetails.Room_Left,CodeDetails.Tallest,CodeDetails.TotalKL from Code inner join CodeDetails on Code.id = CodeDetails.id where Code.id = @ID
	end try
	begin catch
		select
			ERROR_NUMBER() AS ErrorNumber,  
			ERROR_MESSAGE() AS ErrorMessage,
			ERROR_LINE()AS ErrorLine
	end catch

exec SP_GetPiceList
-- Insert code
create proc SP_InsertPriceList
@PRICE_TC float,
@PRICE_TRAN FLOAT,
@PRICE_SAN FLOAT,
@G3_BUY FLOAT,
@KL3_BUY DECIMAL,
@G2_BUY FLOAT,
@KL2_BUY DECIMAL,
@G1_BUY FLOAT,
@KL1_BUY DECIMAL,
@PRICE_ORDEREXECUTION FLOAT,
@KL_ORDEREXECUTION DECIMAL,
@G1_SELL FLOAT,
@KL1_SELL DECIMAL,
@G2_SELL FLOAT,
@KL2_SELL DECIMAL,
@G3_SELL FLOAT,
@KL3_SELL DECIMAL,
@TOTALKL DECIMAL,
@OPENDOOR FLOAT,
@TALLEST FLOAT,
@LOWEST FLOAT,
@NNBUY FLOAT,
@NNSELL FLOAT,
@ROOM_LEFT DECIMAL
as
	begin try
		insert into CodeDetails(Price_TC,Price_Tran,Price_San,G3_Buy,KL3_Buy,G2_Buy,KL2_Buy,G1_Buy,KL1_Buy,Price_OrderExecution,
		KL_OrderExecution,G1_Sell,KL1_Sell,G2_Sell,KL2_Sell,G3_Sell,KL3_Sell,TotalKL,OpenDoor,Tallest,Lowest,NNBuy,NNSell,Room_Left)
		values (@PRICE_TC,@PRICE_TRAN,@PRICE_SAN,@G3_BUY,@KL3_BUY,@G2_BUY,@KL2_BUY,@G1_BUY,@KL1_BUY,@PRICE_ORDEREXECUTION,
		@KL_ORDEREXECUTION,@G1_SELL,@KL1_SELL,@G2_SELL,@KL2_SELL,@G3_SELL,@KL3_SELL,@TOTALKL,@OPENDOOR,@TALLEST,@LOWEST,@NNBUY,@NNSELL,@ROOM_LEFT)
	end try
	begin catch
		select
			ERROR_NUMBER() AS ErrorNumber,  
			ERROR_MESSAGE() AS ErrorMessage,
			ERROR_LINE()AS ErrorLine
	end catch

-- Update code
create proc SP_UpdatePriceList
@ID INT,
@PRICE_TC float,
@PRICE_TRAN FLOAT,
@PRICE_SAN FLOAT,
@G3_BUY FLOAT,
@KL3_BUY DECIMAL,
@G2_BUY FLOAT,
@KL2_BUY DECIMAL,
@G1_BUY FLOAT,
@KL1_BUY DECIMAL,
@PRICE_ORDEREXECUTION FLOAT,
@KL_ORDEREXECUTION DECIMAL,
@G1_SELL FLOAT,
@KL1_SELL DECIMAL,
@G2_SELL FLOAT,
@KL2_SELL DECIMAL,
@G3_SELL FLOAT,
@KL3_SELL DECIMAL,
@TOTALKL DECIMAL,
@OPENDOOR FLOAT,
@TALLEST FLOAT,
@LOWEST FLOAT,
@NNBUY FLOAT,
@NNSELL FLOAT,
@ROOM_LEFT DECIMAL
as
	begin try
		update CodeDetails set Price_TC = @PRICE_TC , Price_Tran = @PRICE_TRAN,Price_San= @PRICE_SAN,G3_Buy = @G3_BUY,KL3_Buy = @KL3_BUY,G2_Buy = @G2_BUY,
		KL2_Buy=@KL2_BUY,G1_Buy=@G1_BUY,KL1_Buy=@KL1_BUY,Price_OrderExecution=@PRICE_ORDEREXECUTION,KL_OrderExecution = @KL_ORDEREXECUTION,
		G1_Sell=@G1_SELL,KL1_Sell=@KL1_SELL,G2_Sell=@G2_SELL,KL2_Sell=@KL2_SELL,G3_Sell=@G3_SELL,KL3_Sell=@KL3_SELL,
		TotalKL=@TOTALKL,OpenDoor = @OPENDOOR,Tallest = @TALLEST,Lowest= @LOWEST,NNBuy= @NNBUY,NNSell = @NNSELL,Room_Left = @ROOM_LEFT 
		where id = @ID
	end try
	begin catch
		select
			ERROR_NUMBER() AS ErrorNumber,  
			ERROR_MESSAGE() AS ErrorMessage,
			ERROR_LINE()AS ErrorLine
	end catch

-- DELETE CODE DETAILS
CREATE PROC SP_DeletePriceList
@ID INT 
AS
	begin try
		delete from CodeDetails where id = @ID
	end try
	begin catch
		select
			ERROR_NUMBER() AS ErrorNumber,  
			ERROR_MESSAGE() AS ErrorMessage,
			ERROR_LINE()AS ErrorLine
	end catch



-- SP CRUD CODE (MA CHUNG KHOAN)

--INSERT
CREATE PROC SP_InsertCode
@NAME_CODE VARCHAR(200),
@ID_DETAILS INT
AS
	begin try
		INSERT INTO Code (name_code,id_details)VALUES(@NAME_CODE,@ID_DETAILS)
	end try
	begin catch
		select
			ERROR_NUMBER() AS ErrorNumber,  
			ERROR_MESSAGE() AS ErrorMessage,
			ERROR_LINE()AS ErrorLine
	end catch

-- UPDATE
CREATE PROC SP_UpdateCode
@ID int ,
@NAME_CODE VARCHAR(200),
@ID_DETAILS INT
AS
	begin try
		update Code  set name_code = @NAME_CODE , id_details = @ID_DETAILS where id = @ID
	end try
	begin catch
		select
			ERROR_NUMBER() AS ErrorNumber,  
			ERROR_MESSAGE() AS ErrorMessage,
			ERROR_LINE()AS ErrorLine
	end catch
-- DELETE
CREATE PROC SP_DeleteCode
@ID int
AS
	begin try
		delete from Code  where id = @ID
	end try
	begin catch
		select
			ERROR_NUMBER() AS ErrorNumber,  
			ERROR_MESSAGE() AS ErrorMessage,
			ERROR_LINE()AS ErrorLine
	end catch

-- CRUD User

-- SELECT
CREATE PROC SP_SelectUser
AS
	begin try
		select * from Users
	end try
	begin catch
		select
			ERROR_NUMBER() AS ErrorNumber,  
			ERROR_MESSAGE() AS ErrorMessage,
			ERROR_LINE()AS ErrorLine
	end catch

-- SELECT BY ID
CREATE PROC SP_SelectUserById
@ID int
AS
	begin try
		select * from Users where id = @ID
	end try
	begin catch
		select
			ERROR_NUMBER() AS ErrorNumber,  
			ERROR_MESSAGE() AS ErrorMessage,
			ERROR_LINE()AS ErrorLine
	end catch

-- INSERT
ALTER PROC SP_InsertUser
@NAME nvarchar(200),
@EMAIL nvarchar(200),
@PASSWORD varchar(100)
as
	begin try
		INSERT INTO Users(Name,Email,Password,Temppass) values (@NAME,@EMAIL,@PASSWORD,'123456')
	end try
	begin catch
		select
			ERROR_NUMBER() AS ErrorNumber,  
			ERROR_MESSAGE() AS ErrorMessage,
			ERROR_LINE()AS ErrorLine
	end catch

-- UPDATE
CREATE PROC SP_UpdateUser
@ID int,
@NAME nvarchar(200),
@EMAIL nvarchar(200),
@PASSWORD varchar(100)
as
	begin try
		UPDATE Users SET Name=@NAME , Email = @EMAIL,Password=@PASSWORD
	end try
	begin catch
		select
			ERROR_NUMBER() AS ErrorNumber,  
			ERROR_MESSAGE() AS ErrorMessage,
			ERROR_LINE()AS ErrorLine
	end catch

--DELETE
CREATE PROC SP_DeleteUser
@ID int
as
	begin try
		DELETE FROM Users where id = @ID
	end try
	begin catch
		select
			ERROR_NUMBER() AS ErrorNumber,  
			ERROR_MESSAGE() AS ErrorMessage,
			ERROR_LINE()AS ErrorLine
	end catch