SELECT Id = IDENTITY(INT, 1, 1), MyNumber into #t FROM dbo.Numbers

SELECT Result = MyNumber * 5378 FROM #t WHERE Id = 1953