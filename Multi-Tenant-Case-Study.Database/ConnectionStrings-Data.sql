/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
INSERT INTO ConnectionStrings
SELECT 'stark.localhost.com', 'Connection string for stark'
UNION ALL
SELECT 'colson.localhost.com', 'Connection string for colson'
UNION ALL
SELECT 'fury.localhost.com', 'Connection string for fury'