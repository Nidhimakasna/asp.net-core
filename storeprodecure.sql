-----------------------------------------------------------USER-----------------------------------------------------------------------------------
-- User TABLE SELECT ALL PROCEDURE
CREATE OR ALTER PROCEDURE	[DBO].[PR_User_SelectAll]
AS
BEGIN
	SELECT	[DBO].[User].[UserID],
			[DBO].[User].[UserName],
			[DBO].[User].[Password],
			[DBO].[User].[Email],
			[DBO].[User].[MobileNo], 
			[DBO].[User].[IsActive],
			[DBO].[User].[Created],
			[DBO].[User].[Modified]
			FROM [DBO].[User]
END
--[DBO].[PR_User_SelectAll] 


--User TABLE SELECT BY PK PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_User_SelectByPK]
@UserID INT
AS
BEGIN
	SELECT	[DBO].[User].[UserID],
			[DBO].[User].[UserName],
			[DBO].[User].[Password],
			[DBO].[User].[Email],
			[DBO].[User].[MobileNo], 
			[DBO].[User].[IsActive],
			[DBO].[User].[Created],
			[DBO].[User].[Modified]
			FROM [DBO].[User]
			WHERE [DBO].[User].[UserID] = @UserID
END
--[DBO].[PR_User_SelectByPK] 2


--User TABLE INSERT PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_User_Insert]
@UserName     nvarchar(100),
@PassWord     nvarchar(100),
@Email        nvarchar(100),
@MobileNo     nvarchar(100),
@IsActive     bit,
@Created      DateTime,
@Modified     DateTime

AS
BEGIN
	INSERT INTO [DBO].[User]
	(
		    [DBO].[User].[UserName],
			[DBO].[User].[Password],
			[DBO].[User].[Email],
			[DBO].[User].[MobileNo], 
			[DBO].[User].[IsActive],
			[DBO].[User].[Created],
			[DBO].[User].[Modified]
		
	)
	VALUES
	(
		
		@UserName ,
		@PassWord ,
		@Email ,
		@MobileNo,
		@IsActive,
		@Created ,
		@Modified
			)
END
EXEC [dbo].[PR_User_Insert] 'rahul_sharma','rahul123', 'rahul@example.com', '9876543210',  1,'2025-04-04','2024-02-03';
--[DBO].[PR_User_SelectAll] 



--USER TABLE UPDATE BY PK PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_User_UpdateByPK]
@UserID       int,
@UserName     nvarchar(100),
@PassWord     nvarchar(100),
@Email        nvarchar(100),
@MobileNo     nvarchar(100),
@IsActive     bit,
@Created      DateTime,
@Modified     DateTime
AS
BEGIN
	UPDATE [DBO].[User]

	SET	[DBO].[User].[UserName] =@UserName ,
		[DBO].[User].[Password] =@PassWord ,
		[DBO].[User].[Email] = @Email,
		[DBO].[User].[MobileNo] = @MobileNo,
		[DBO].[User].[IsActive] = @IsActive,
		[DBO].[User].[Created] = @Created,
		[DBO].[User].[Modified]=@Modified

	WHERE [DBO].[User].[UserID] = @UserID
END
EXEC [dbo].[PR_User_UpdateByPK] 6, 'raj_sharma','rahul123', 'rahul@example.com', '9876543210',  1,'2025-04-04','2024-02-03';
--[DBO].[PR_User_SelectAll] 


--User TABLE DELETE BY PK PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_User_DeleteByPK]
@UserID INT
AS
BEGIN
	DELETE 
	FROM [DBO].[User]
	WHERE [DBO].[User].[UserID] = @UserID
END
--[DBO].[PR_User_DeleteByPK] 7

-----------------------------------------------------------------------DEPARTMENT--------------------------------------------------------------------

-- DEPARTMENT TABLE SELECT ALL PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].PR_Department_SelectAll
AS
BEGIN
	SELECT	[DBO].[Department].[DepartmentID],
			[DBO].[Department].[DepartmentName],
			[DBO].[Department].[Description],
			[DBO].[Department].[IsActive],
			[DBO].[Department].[Created],
			[DBO].[Department].[Modified], 
			[DBO].[User].[UserID]
			FROM [DBO].[Department]

			INNER JOIN [DBO].[User]
			ON [DBO].[User].[UserID]=[DBO].[Department].[UserID]
END
--[DBO].[PR_Department_SelectAll] 


--DEPARTMENT TABLE SELECT BY PK PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_Department_SelectByPK]
@DepartmentID INT
AS
BEGIN
	SELECT	
			[DBO].[Department].[DepartmentID],
			[DBO].[Department].[DepartmentName],
			[DBO].[Department].[IsActive],
			[DBO].[Department].[Created],
			[DBO].[Department].[Modified], 
			[DBO].[Department].[Description],
			[DBO].[User].[UserID]
			FROM [DBO].[Department]
			INNER JOIN [DBO].[User]
			ON [DBO].[User].[UserID]=[DBO].[Department].[UserID]
			WHERE [DBO].[Department].[DepartmentID] = @DepartmentID
END
--[DBO].[PR_Department_SelectByPK] 2


--DEPARTMENT TABLE INSERT PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_Department_Insert]
@DEPARTMENT_NAME  NVARCHAR(100),
@DESCRIPTION      NVARCHAR(100),
@IS_ACTIVE        BIT,
@CREATED          DATETIME,
@MODIFIED         DATETIME,
@USERID           INT
AS
BEGIN
	INSERT INTO [DBO].[Department]
	(
		
		[DBO].[Department].[DepartmentName],
		[DBO].[Department].[Description],
		[DBO].[Department].[IsActive],
		[DBO].[Department].[Created],
		[DBO].[Department].[Modified],
		[DBO].[Department].[UserID]
	)
	VALUES
	(
		
		@DEPARTMENT_NAME,
		@DESCRIPTION,
		@IS_ACTIVE,
		@CREATED,
		@MODIFIED,
		@USERID
	)
END
EXEC [DBO].[PR_Department_Insert] 'Cardiology', 'Heart-related department',1, '2004-03-04','2004-03-03' ,1
--[DBO].[PR_Department_SelectAll] 


--DEPARTMENT TABLE UPDATE BY PK PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_Department_UpdateByPK]
@DEPARTMENT_ID          INT,
@DEPARTMENT_NAME        NVARCHAR(100),
@DESCRIPTION            NVARCHAR(100),
@IS_ACTIVE              BIT,
@CREATED                DATETIME,
@MODIFIED               DATETIME,
@USERID                 INT
AS
BEGIN
	UPDATE [DBO].[Department]
	SET	[DBO].[Department].[DepartmentName] = @DEPARTMENT_NAME,
		[DBO].[Department].[IsActive] = @IS_ACTIVE,
		[DBO].[Department].[Created] = @CREATED,
		[DBO].[Department].[Modified] = @MODIFIED,
		[DBO].[Department].[Description] = @DESCRIPTION,
		[DBO].[Department].[UserID] = @USERID

	WHERE [DBO].[Department].[DepartmentID] = @DEPARTMENT_ID
END
EXEC [DBO].[PR_Department_UpdateByPK] 6, 'Cardiology', 'Heart-related department',1, '2004-03-04','2004-03-09' ,1
--[DBO].[PR_Department_SelectAll] 

--DEPARTMENT TABLE DELETE BY PK PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_Department_DeleteByPK]
@DEPARTMENT_ID INT
AS
BEGIN
	DELETE 
	FROM [DBO].[Department]
	WHERE [DBO].[Department].[DepartmentID] = @DEPARTMENT_ID
END
--[DBO].[PR_Department_DeleteByPK] 3

--------------------------------------------------------------------DOCTOR--------------------------------------------------------------------
-- Doctor TABLE SELECT ALL PROCEDURE
CREATE OR ALTER PROCEDURE	[DBO].[PR_Doctor_SelectAll]
AS 
BEGIN
	SELECT	[DBO].[Doctor].[DoctorID],
			[DBO].[Doctor].[Name],
			[DBO].[Doctor].[Phone],
			[DBO].[Doctor].[Email],
			[DBO].[Doctor].[Qualification], 
			[DBO].[Doctor].[Specialization],
			[DBO].[Doctor].[IsActive],
			[DBO].[Doctor].[Created],
			[DBO].[Doctor].[Modified],
			[DBO].[User].[UserID]
			FROM [DBO].[Doctor]
			INNER JOIN [DBO].[User]
			ON [DBO].[User].[UserID]=[DBO].[Doctor].[UserID]
END
--[DBO].[PR_Doctor_SelectAll] 


--Doctor TABLE SELECT BY PK PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_Doctor_SelectByPK]
@DoctorID INT
AS
BEGIN
	SELECT	[DBO].[Doctor].[DoctorID],
			[DBO].[Doctor].[Name],
			[DBO].[Doctor].[Phone],
			[DBO].[Doctor].[Email],
			[DBO].[Doctor].[Qualification], 
			[DBO].[Doctor].[Specialization],
			[DBO].[Doctor].[IsActive],
			[DBO].[Doctor].[Created],
			[DBO].[Doctor].[Modified],
			[DBO].[User].[UserID]
			FROM [DBO].[Doctor]
			INNER JOIN [DBO].[User]
			ON [DBO].[User].[UserID]=[DBO].[Doctor].[UserID]
			WHERE [DBO].[Doctor].[DoctorID] = @DoctorID
END
--[DBO].[PR_Doctor_SelectByPK] 2


--DOCTORT TABLE INSERT PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_Doctor_Insert]

@Name               nvarchar(100),
@Phone              nvarchar(20),
@Email              nvarchar(100),
@Qualification      nvarchar(100),
@Specialization     nvarchar(100),
@IS_ACTIVE          BIT,
@CREATED            DATETIME,
@MODIFIED           DATETIME,
@USERID             INT
AS
BEGIN
	INSERT INTO [DBO].[Doctor]
	(
		
			[DBO].[Doctor].[Name],
			[DBO].[Doctor].[Phone],
			[DBO].[Doctor].[Email],
			[DBO].[Doctor].[Qualification], 
			[DBO].[Doctor].[Specialization],
			[DBO].[Doctor].[IsActive],
			[DBO].[Doctor].[Created],
			[DBO].[Doctor].[Modified],
			[DBO].[Doctor].[UserID]
		   
	)
	VALUES
	(
		
		@Name,
		@Phone,
		@Email,
		@Qualification,
		@Specialization,
		@IS_ACTIVE,
		@CREATED,
		@MODIFIED ,
		@USERID 
	)
END
EXEC [DBO].[PR_Doctor_Insert] N'Dr. Emily Carter', N'+1-444-555-6666', N'emily.carter@example.com', N'MBBS, DGO', N'Gynecology',1,'2005-02-03' ,'2004-10-01' ,6
--[DBO].[PR_Doctor_SelectAll] 


--DOCTOR TABLE UPDATE BY PK PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_Doctor_UpdateByPK]
@DoctorID INT,
@Name               nvarchar(100),
@Phone              nvarchar(20),
@Email              nvarchar(100),
@Qualification      nvarchar(100),
@Specialization     nvarchar(100),
@IsActive           BIT,
@CREATED            DATETIME,
@MODIFIED           DATETIME,
@USERID             INT
AS
BEGIN
	UPDATE [DBO].[Doctor]
	SET    [DBO].[Doctor].[Name]=@Name,
			[DBO].[Doctor].[Phone]=@Phone,
			[DBO].[Doctor].[Email]=@Email,
			[DBO].[Doctor].[Qualification]=@Qualification, 
			[DBO].[Doctor].[Specialization]=@Specialization,
			[DBO].[Doctor].[IsActive]=@IsActive,
			[DBO].[Doctor].[Created]=@Created,
			[DBO].[Doctor].[Modified]=@Modified,
			[DBO].[Doctor].[UserID]=@UserID

	WHERE [DBO].[Doctor].[DoctorID] = @DoctorID
END
EXEC [DBO].[PR_Doctor_UpdateByPK] 10, N'Dr. Emily Carter', '9558064464', N'emily.carter@example.com', N'MBBS, DGO', N'Gynecology',1,'2005-02-03' ,'2004-10-01' ,6
--[DBO].[PR_Doctor_SelectAll] 


--Doctor TABLE DELETE BY PK PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_Doctor_DeleteByPK]
@Doctor_ID INT
AS
BEGIN
	DELETE 
	FROM [DBO].[Doctor]
	WHERE [DBO].[Doctor].[DoctorID] = @Doctor_ID
END
--[DBO].[PR_Doctor_DeleteByPK] 9
--[DBO].[PR_Doctor_SelectAll] 
-------------------------------------------------------------------DOCTORDEPARTMENT--------------------------------------------------------------
--   DoctorDepartment TABLE SELECT ALL PROCEDURE
CREATE OR ALTER PROCEDURE	[DBO].[PR_DoctorDepartment_SelectAll]
AS 
BEGIN
	SELECT	
			[DBO].[DoctorDepartment].[DoctorDepartmentID],
			[DBO].[Doctor].[DoctorID],
			[DBO].[Department].[DepartmentID],
			[DBO].[DoctorDepartment].[Created],
			[DBO].[DoctorDepartment].[Modified],
			[DBO].[User].[UserID]
			FROM [DBO].[DoctorDepartment]

			INNER JOIN [DBO].[Doctor]
			ON [DBO].[Doctor].[DoctorID]=[DBO].[DoctorDepartment].[DoctorID]

			INNER JOIN [DBO].[Department]
			ON [DBO].[Department].[DepartmentID]=[DBO].[DoctorDepartment].[DepartmentID]

			INNER JOIN [DBO].[User]
			ON [DBO].[User].[UserID]=[DBO].[DoctorDepartment].[UserID]	
END
--[DBO].[PR_DoctorDepartment_SelectAll] 

--DoctorDepartment  TABLE SELECT BY PK PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_DoctorDepartment_SelectByPK]
@DoctorDepartmenTID INT
AS
BEGIN
	     SELECT [DBO].[DoctorDepartment].[DoctorDepartmentID],
			  [DBO].[Doctor].[DoctorID],
			  [DBO].[Department].[DepartmentID],
			  [DBO].[DoctorDepartment].[Created],
			  [DBO].[DoctorDepartment].[Modified],
			  [DBO].[User].[UserID]
			  FROM [DBO].[DoctorDepartment]
			  INNER JOIN [DBO].[Doctor]
			  ON [DBO].[Doctor].[DoctorID]=[DBO].[DoctorDepartment].[DoctorID]

			  INNER JOIN [DBO].[Department]
			  ON [DBO].[Department].[DepartmentID]=[DBO].[DoctorDepartment].[DepartmentID]

			  INNER JOIN [DBO].[User]
			  ON [DBO].[User].[UserID]=[DBO].[DoctorDepartment].[UserID]
	
			  WHERE [DBO].[DoctorDepartment].[DoctorDepartmentID]=@DoctorDepartmentID
END
--[DBO].[PR_DoctorDepartment_SelectByPK] 2


--DoctorDepartment TABLE INSERT PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_DoctorDepartment_Insert]
@DoctorID            int,
@DepartmentID        int,
@Created             DATETIME,
@Modified            DATETIME,
@USERID              int
AS
BEGIN
	INSERT INTO [DBO].[DoctorDepartment]
	(
			[DBO].[DoctorDepartment].[DoctorID],
			[DBO].[DoctorDepartment].[DepartmentID],
			[DBO].[DoctorDepartment].[Created],
			[DBO].[DoctorDepartment].[Modified],
			[DBO].[DoctorDepartment].[UserID]	    
	)
	VALUES
	(
			@DoctorID,
			@DepartmentID,
			@Created ,          
			@Modified ,          
			@UserID          
	)
END


EXEC [DBO].[PR_DoctorDepartment_Insert] 5, 6,'2024-01-15','2024-01-15', 6
EXEC [DBO].[PR_DoctorDepartment_Insert] 2, 2, '2024-02-20', '2024-02-20',2
--[DBO].[PR_DoctorDepartment_SelectAll] 


--DoctorDepartment   TABLE UPDATE BY PK PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_DoctorDepartment_UpdateByPK]
@DoctorDepartmentID   int,
@DoctorID             int,
@DepartmentID         int,
@Created              DATETIME,
@Modified             DATETIME,
@USERID               int
AS
BEGIN
	UPDATE [DBO].[DoctorDepartment]
	SET	   
			[DBO].[DoctorDepartment].[DoctorID]= @DoctorID,
			[DBO].[DoctorDepartment].[DepartmentID]= @DepartmentID,
			[DBO].[DoctorDepartment].[Created]=@Created,
			[DBO].[DoctorDepartment].[Modified]=@Modified, 
			[DBO].[DoctorDepartment].[UserID]=@UserID
	        WHERE [DBO].[DoctorDepartment].[DoctorDepartmentID] =@DoctorDepartmentID
END
EXEC [DBO].[PR_DoctorDepartment_UpdateByPK] 7,5, 5,'2024-01-15','2024-01-15', 5
--[DBO].[PR_DoctorDepartment_SelectAll] 

-- DoctorDepartment  TABLE DELETE BY PK PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_DoctorDepartment_DeleteByPK]
@DoctorDepartmentID   INT
AS
BEGIN
	DELETE 
	FROM [DBO].[DoctorDepartment]
	WHERE [DBO].[DoctorDepartment].[DoctorDepartmentID] = @DoctorDepartmentID
END
--[DBO].[PR_DoctorDepartment_DeleteByPK] 8
--[DBO].[PR_DoctorDepartment_SelectAll] 

-----------------------------------------------------------------PATIENT------------------------------------------------------------------------

--  Patient   TABLE SELECT ALL PROCEDURE
CREATE OR ALTER PROCEDURE	[DBO].[PR_Patient_SelectAll]
AS 
BEGIN
	SELECT	[DBO].[Patient].[PatientID],
			[DBO].[Patient].[Name],
			[DBO].[Patient].[DateOfBirth],
			[DBO].[Patient].[Gender],
			[DBO].[Patient].[Email],
			[DBO].[Patient].[Phone],
			[DBO].[Patient].[Address],
			[DBO].[Patient].[City],
			[DBO].[Patient].[State],
			[DBO].[Patient].[IsActive],
			[DBO].[Patient].[Created],
			[DBO].[Patient].[Modified], 
			[DBO].[User].[UserID]
			FROM [DBO].[Patient]
			INNER JOIN [DBO].[User]
			ON [DBO].[User].[UserID]=[DBO].[Patient].[UserID]
END
--[DBO].[PR_Patient_SelectAll] 

--Patient TABLE SELECT BY PK PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_atient_SelectByPK]
@PatientID INT
AS
BEGIN
	SELECT	[DBO].[Patient].[PatientID],
			[DBO].[Patient].[Name],
			[DBO].[Patient].[DateOfBirth],
			[DBO].[Patient].[Gender],
			[DBO].[Patient].[Phone],
			[DBO].[Patient].[Address],
			[DBO].[Patient].[City],
			[DBO].[Patient].[State],
			[DBO].[Patient].[IsActive],
			[DBO].[Patient].[Created],
			[DBO].[Patient].[Modified], 
			[DBO].[User].[UserID]
			FROM [DBO].[Patient]
			INNER JOIN [DBO].[User]
			ON [DBO].[User].[UserID]=[DBO].[Patient].[UserID]
			WHERE [DBO].[Patient].[PatientID]=@PatientID
END
--[DBO].[PR_atient_SelectByPK] 2



--Patient TABLE INSERT PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_Patient_Insert]
@Name			    nvarchar(100),
@DateOfBirth		DateTime,
@Gender				nvarchar(100),
@Email				nvarchar(100),
@Phone				nvarchar(100),
@Address			nvarchar(100),
@City				nvarchar(100),
@State				nvarchar(100),
@IsActive           BIT,
@CREATED            DATETIME,
@MODIFIED           DATETIME,
@USERID             INT

AS
BEGIN
	INSERT INTO [DBO].[Patient]
	(
		
		    
			[DBO].[Patient].[Name],
			[DBO].[Patient].[DateOfBirth],
			[DBO].[Patient].[Gender],
			[DBO].[Patient].[Email],
			[DBO].[Patient].[Phone],
			[DBO].[Patient].[Address],
			[DBO].[Patient].[City],
			[DBO].[Patient].[State],
			[DBO].[Patient].[IsActive],
			[DBO].[Patient].[Created],
			[DBO].[Patient].[Modified], 
			[DBO].[Patient].[UserID]
			
	)
	VALUES
	(
		
			@Name,
			@DateOfBirth,
			@Gender,
			@Email,
			@Phone,
			@Address,
			@City,
			@State,
			@IsActive ,        
			@Created ,          
			@Modified ,          
			@UserID          

	)
END
EXEC [DBO].[PR_Patient_Insert] N'John Smith', '1985-03-15', N'Male', N'john.smith@example.com', N'+1-555-100-2000', N'123 Main Street', N'New York', N'NY', 1, '2003-02-04', '2005-04-07', 1;
EXEC [DBO].[PR_Patient_Insert] N'John Trump ', '1985-03-15', N'Male', N'john.trump@example.com', N'+1-555-100-2000', N'123 Main Street', N'New York', N'NY', 1, '2003-02-04', '2005-04-07', 5;



--DEPARTMENT TABLE UPDATE BY PK PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_Patient_UpdateByPK]
@PatientID INT,
@Name			    nvarchar(100),
@DateOfBirth		DateTime,
@Gender				nvarchar(100),
@Email				nvarchar(100),
@Phone				nvarchar(100),
@Address			nvarchar(100),
@City				nvarchar(100),
@State				nvarchar(100),
@IsActive           BIT,
@Created            DATETIME,
@Modified           DATETIME,
@UserID             INT

AS
BEGIN
	UPDATE [DBO].[Patient]

	SET	[DBO].[Patient].[Name]=@Name,
			[DBO].[Patient].[DateOfBirth]=@DateOfBirth,
			[DBO].[Patient].[Gender]=@Gender,
			[DBO].[Patient].[Phone]=@Phone,
			[DBO].[Patient].[Address]=@Address,
			[DBO].[Patient].[City]=@City,
			[DBO].[Patient].[State]=@State,
			[DBO].[Patient].[IsActive]=@IsActive,
			[DBO].[Patient].[Created]=@Created,
			[DBO].[Patient].[Modified]=@Modified, 
			[DBO].[Patient].[UserID]=@UserID
			

	WHERE [DBO].[Patient].[PatientID] = @PatientID
END
EXEC [DBO].[PR_Patient_UpdateByPK] 6, N'John Smith', '1985-03-15', N'Male', N'john.smith@example.com', N'+1-555-100-2000', N'123 Main Street', N'New York', N'NY', 1, '2003-02-04', '2005-04-07', 6;
[DBO].[PR_Patient_SelectAll] 

--PATIENT TABLE DELETE BY PK PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_Patient_DeleteByPK]
@PatientID INT
AS
BEGIN
	DELETE 
	FROM [DBO].[Patient]
	WHERE [DBO].[Patient].[PatientID] = @PatientID
END
--[DBO].[PR_Patient_DeleteByPK] 7
--[DBO].[PR_Patient_SelectAll] 

-----------------------------------------------------------------APPOINTMENT------------------------------------------------------------------------

-- Appointment TABLE SELECT ALL PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_Appointment_SelectAll] 
AS
BEGIN
	SELECT	[DBO].[Appointment].[AppointmentID],
			[DBO].[Doctor].[DoctorID],
			[DBO].[Patient].[PatientID],
			[DBO].[Appointment].[AppointmentDate],
			[DBO].[Appointment].[AppointmentStatus] , 
			[DBO].[Appointment].[Description],
			[DBO].[Appointment].[SpecialRemarks],
			[DBO].[Appointment].[Created],
			[DBO].[Appointment].[Modified],
			[DBO].[User].[UserID],
			[DBO].[Appointment].[TotalConsultedAmount]
			FROM [DBO].[Appointment]
			INNER JOIN [DBO].[Doctor]
			ON [DBO].[Doctor].[DoctorID]=[DBO].[Appointment].[DoctorID]

			INNER JOIN [DBO].[Patient]
			ON [DBO].[Patient].[PatientID]=[DBO].[Appointment].[PatientID]

			INNER JOIN [DBO].[User]
			ON [DBO].[User].[UserID]=[DBO].[Appointment].[UserID]
			
END
--[DBO].[PR_Appointment_SelectAll] 

--Appointment TABLE SELECT BY PK PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_Appointment_SelectByPK]
@AppointmentID INT
AS
BEGIN
	SELECT	[DBO].[Appointment].[AppointmentID],
			[DBO].[Appointment].[DoctorID],
			[DBO].[Appointment].[PatientID],
			[DBO].[Appointment].[AppointmentDate],
			[DBO].[Appointment].[AppointmentStatus] , 
			[DBO].[Appointment].[Description],
			[DBO].[Appointment].[SpecialRemarks],
			[DBO].[Appointment].[Created],
			[DBO].[Appointment].[Modified],
			[DBO].[Appointment].[UserID],
			[DBO].[Appointment].[TotalConsultedAmount]
			FROM [DBO].[Appointment]
			WHERE [DBO].[Appointment].[AppointmentID] = @AppointmentID
END
--[DBO].[PR_Appointment_SelectByPK] 1

--Appointment TABLE INSERT PROCEDURE
CREATE OR ALTER PROCEDURE PR_Appointment_Insert
	@DoctorID             INT ,
	@PatientID            INT ,
	@AppointmentDate      DATETIME ,
	@AppointmentStatus    NVARCHAR(100),
	@Description          NVARCHAR(100),
	@SpecialRemarks       NVARCHAR(100),
	@Created              DATETIME,
	@Modified             DATETIME ,
	@UserID               INT,
	@TotalConsultedAmount DECIMAL
	AS
BEGIN
	INSERT INTO [DBO].[Appointment]
	(
		
			[DBO].[Appointment].[DoctorID],
			[DBO].[Appointment].[PatientID],
			[DBO].[Appointment].[AppointmentDate],
			[DBO].[Appointment].[AppointmentStatus], 
			[DBO].[Appointment].[Description],
			[DBO].[Appointment].[SpecialRemarks],
			[DBO].[Appointment].[Created],
			[DBO].[Appointment].[Modified],
			[DBO].[Appointment].[UserID],
			[DBO].[Appointment].[TotalConsultedAmount]
	)
	VALUES
	(
		@DoctorID,
		@PatientID,
		@AppointmentDate,
		@AppointmentStatus,
		@Description,
		@SpecialRemarks,
		@Created,
		@Modified,
		@UserID ,
		@TotalConsultedAmount
	)
END
EXEC [DBO].[PR_Appointment_Insert]  5, 5,'2025-06-25 10:30:00', N'Completed',N'General consultation', N'Follow-up in 2 weeks','2005-09-06','2005-12-02', 5,500.00;
EXEC [DBO].[PR_Appointment_Insert]  3, 3,'2025-06-25 10:30:00', N'Completed',N'General consultation', N'Follow-up in 2 weeks','2005-09-06','2005-12-02', 6,500.00;
--[DBO].[PR_Appointment_SelectAll] 


--Appointment TABLE UPDATE BY PK PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_Appointment_UpdateByPK]
	@AppointmentID         INT,
	@DoctorID              INT ,
	@PatientID             INT ,
	@AppointmentDate       DATETIME ,
	@AppointmentStatus     NVARCHAR(100),
	@Description           NVARCHAR(100),
	@SpecialRemarks        NVARCHAR(100),
	@Created               DATETIME,
	@Modified              DATETIME ,
	@UserID                INT,
	@TotalConsultedAmount  DECIMAL
AS  
BEGIN
	UPDATE [DBO].[Appointment]
	SET
			
			[DBO].[Appointment].[DoctorID]=@DoctorID,
			[DBO].[Appointment].[PatientID]=@PatientID,
			[DBO].[Appointment].[AppointmentDate]=@AppointmentDate,
			[DBO].[Appointment].[AppointmentStatus]=@AppointmentStatus, 
			[DBO].[Appointment].[Description]=@Description,
			[DBO].[Appointment].[SpecialRemarks]=@SpecialRemarks,
			[DBO].[Appointment].[Created]=@Created,
			[DBO].[Appointment].[Modified]=@Modified,
			[DBO].[Appointment].[UserID]=@UserID,
			[DBO].[Appointment].[TotalConsultedAmount]=@TotalConsultedAmount

	WHERE [DBO].[Appointment].[AppointmentID] = @AppointmentID
END
EXEC [DBO].[PR_Appointment_UpdateByPK] 7, 2, 2,'2025-06-25 10:30:00', N'Completed',N'General consultation', N'Follow-up in 2 weeks','2005-09-06','2005-12-02', 2,500.00;
--[DBO].[PR_Appointment_SelectAll] 


-- Appointment TABLE DELETE BY PK PROCEDURE
CREATE OR ALTER PROCEDURE [DBO].[PR_Appointment_DeleteByPK]
@AppointmentID INT
AS
BEGIN
	DELETE 
	FROM [DBO].[Appointment]
	WHERE [DBO].[Appointment].[AppointmentID] = @AppointmentID
END
--[DBO].[PR_Appointment_DeleteByPK] 9
--[DBO].[PR_Appointment_SelectAll] 
