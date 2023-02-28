alter VIEW V_Addressbook
	AS SELECT a.ID as AddressBookID, b.deptName, a.chinessName,a.Ext,a.mobilePhoneNumber,a.emailAddress FROM addressBook as a
	inner join department as b
		on a.deptID=b.deptID
		
