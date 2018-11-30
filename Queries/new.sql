CREATE LOGIN [imdaad_admin] WITH PASSWORD = 'password';
CREATE USER [imdaad_user] FOR LOGIN [imdaad_admin];
exec sp_addrolemember 'db_owner', 'imdaad_user'