ALTER PROCEDURE sp_addressBook

	@where varchar
AS
	--declare @sqlstring as varchar
	
	--SET @sqlstring =N'SELECT a.ID as AddressBookID, b.deptName, a.chinessName,a.Ext,a.mobilePhoneNumber,a.emailAddress FROM addressBook as a
	--inner join department as b
	--	on a.deptID=b.deptID
	--	where 1=1  ';

		EXEC ( N'SELECT a.ID as AddressBookID, b.deptName, a.chinessName,a.Ext,a.mobilePhoneNumber,a.emailAddress FROM addressBook as a
	inner join department as b
		on a.deptID=b.deptID
		where 1=1  ' + @where )
		;


go


EXEC sp_addressBook  N' and a.deptID="05"'

go

------------------------------------------------------------------------

SELECT a.ID as AddressBookID, b.deptName, a.chinessName,a.Ext,a.mobilePhoneNumber,a.emailAddress FROM addressBook as a
	inner join department as b
		on a.deptID=b.deptID
		where 1=1  and a.deptID='05'

		select * from addressBook