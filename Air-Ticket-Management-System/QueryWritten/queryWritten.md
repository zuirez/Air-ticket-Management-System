# Queries Written for this project

### Creating UserInfo Table

```
CREATE TABLE UserInfo (
    userId INT IDENTITY(1,1) PRIMARY KEY,
    userName NVARCHAR(50) NOT NULL,
    userPassword NVARCHAR(50) NOT NULL,
    userEmail NVARCHAR(50) NOT NULL,
    userAddress NVARCHAR(50) NOT NULL,
    userGender NVARCHAR(10) NOT NULL,
    userIdType INT NOT NULL,
    CONSTRAINT FK_UserInfo_UserType FOREIGN KEY (userIdType) 
        REFERENCES UserType(userIdType)
);
```

### Creating UserType Table

1. Creating the table
```
CREATE TABLE UserType (
    userIdType INT IDENTITY(1,1) PRIMARY KEY,
    title NVARCHAR(50) NOT NULL
);
```

2. Inserting roles
```
INSERT INTO UserType (title) VALUES ('Admin');
INSERT INTO UserType (title) VALUES ('Employee');
INSERT INTO UserType (title) VALUES ('Passenger');
```

3. Adding foreign key
```
ALTER TABLE UserInfo
ADD CONSTRAINT FK_UserInfo_UserType
FOREIGN KEY (userIdType) REFERENCES UserType(userIdType);
```

# Adding data to UserInfo Table

