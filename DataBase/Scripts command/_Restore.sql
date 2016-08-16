USE [master]
ALTER DATABASE Tazrigh SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
restore database Tazrigh from disk='E:\cs\BK_1395_04_26_4_35.bak' with replace