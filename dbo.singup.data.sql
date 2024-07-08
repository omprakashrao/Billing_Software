SET IDENTITY_INSERT [dbo].[singup] ON
INSERT INTO [dbo].[singup] ([Id], [name], [surname], [gender], [age], [address], [email], [password]) VALUES (1, N'akshay', N'bhati', N'MALE', 5, N'jodhpur', N'omsa@gmail.com', N'123@')
INSERT INTO [dbo].[singup] ([Id], [name], [surname], [gender], [age], [address], [email], [password]) VALUES (2, N'om', N'', N'MALE', 30, N'kishore bagh', N'ok@gamil.com', N'9090')
INSERT INTO [dbo].[singup] ([Id], [name], [surname], [gender], [age], [address], [email], [password]) VALUES (3, N'aksu', N'bhati', N'MALE', 3, N'jodhpur', N'aksu@gmail', N'1234')
INSERT INTO [dbo].[singup] ([Id], [name], [surname], [gender], [age], [address], [email], [password]) VALUES (4, N'1', N's', N'MALE', 2, N'sdd', N'sss@gamil.com', N'1111')
SET IDENTITY_INSERT [dbo].[singup] OFF
delete from singup where id=4;