CREATE TABLE [dbo].[personal_info] (
    [id]         INT           IDENTITY (100, 1) NOT NULL,
    [fullname]   VARCHAR (200) NULL,
    [guardian]   VARCHAR (200) NULL,
    [p_address]  VARCHAR (500) NULL,
    [c_address]  VARCHAR (500) NULL,
    [contact_no] VARCHAR (15)  NULL,
    [aadhaar]    VARCHAR (15)  NULL,
    [age]        INT           NULL,
    [verifier]   VARCHAR (300) NULL
);

CREATE TABLE [dbo].[family_tb] (
    [id]             INT           IDENTITY (1, 1) NOT NULL,
    [name]           VARCHAR (200) NULL,
    [relation]       VARCHAR (100) NULL,
    [age]            INT           NULL,
    [education]      VARCHAR (200) NULL,
    [marital_status] VARCHAR (100) NULL,
    [occupation]     VARCHAR (100) NULL,
    [income]         VARCHAR (15)  NULL,
    [person_id]      INT           NULL
);

CREATE TABLE [dbo].[bank_tb] (
    [id]             INT           IDENTITY (1, 1) NOT NULL,
    [name]           VARCHAR (200) NULL,
    [bank_branch]    VARCHAR (200) NULL,
    [ifsc]           VARCHAR (20)  NULL,
    [account_no]     VARCHAR (20)  NULL,
    [account_holder] VARCHAR (30)  NULL,
    [account_type]   VARCHAR (20)  NULL,
    [person_id]      INT           NULL
);

CREATE TABLE [dbo].[other_case_details] (
    [id]                INT           IDENTITY (1, 1) NOT NULL,
    [reason]            VARCHAR (MAX) NULL,
    [whether_receiving] VARCHAR (10)  NULL,
    [recieving_benef]   VARCHAR (MAX) NULL,
    [amount]            MONEY         NULL,
    [person_id]         INT           NULL
);

CREATE TABLE [dbo].[need_details] (
    [id]                 INT   IDENTITY (1, 1) NOT NULL,
    [monthly]            MONEY NULL,
    [medical_assistence] MONEY NULL,
    [marriage_fund]      MONEY NULL,
    [employ_fund]        MONEY NULL,
    [otr_fund]           MONEY NULL,
    [other_fund]         MONEY NULL,
    [person_id]          INT   NULL
);

CREATE TABLE [dbo].[remarks_tb] (
    [id]        INT           IDENTITY (1, 1) NOT NULL,
    [startDate] DATE          NULL,
    [endDate]   DATE          NULL,
    [comments]  VARCHAR (500) NULL,
    [status]    VARCHAR (50)  NULL,
    [person_id] INT           NULL
);

CREATE TABLE [dbo].[photo] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [photo_path] VARCHAR (150) NULL,
    [person_id]  INT           NULL
);

CREATE TABLE [dbo].[teamImdaad_tb] (
    [id]      INT           IDENTITY (1, 1) NOT NULL,
    [name]    VARCHAR (300) NULL,
    [address] VARCHAR (500) NULL,
    [contact] VARCHAR (15)  NULL
);

CREATE TABLE [dbo].[donors_tb] (
    [id]              INT           IDENTITY (1, 1) NOT NULL,
    [name]            VARCHAR (200) NULL,
    [guardian]        VARCHAR (200) NULL,
    [donor_address]   VARCHAR (500) NULL,
    [contact]         VARCHAR (20)  NULL,
    [donation_amount] VARCHAR (15)  NULL,
    [donation_date]   VARCHAR (30)  NULL
);



