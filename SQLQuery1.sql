USE [CrudDemo]  
GO  
CREATE TABLE [dbo].[studentmaster](  
    [Id] [int] IDENTITY(1,1) NOT NULL,  
    [Name] [varchar](50) NULL,  
    [RollNo] [varchar](50) NULL,  
    [Class] [varchar](50) NULL,  
    [Address] [varchar](50) NULL,  
 CONSTRAINT [PK_studentmaster] PRIMARY KEY CLUSTERED   
(  
    [Id] ASC  
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]  
) ON [PRIMARY]  

GO  