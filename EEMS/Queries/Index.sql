USE [EEMS]
GO
CREATE NONCLUSTERED INDEX [IX_Payment_counterhistoryid]
ON [dbo].[Payment] ([counterhistoryid])
INCLUDE ([pvalue])
GO