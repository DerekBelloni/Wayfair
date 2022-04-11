CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';
CREATE TABLE IF NOT EXISTS reservations(
  id INT NOT NULL AUTO_INCREMENT primary key,
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  reservationType TEXT NOT Null,
  reservationName TEXT NOT NULL,
  confirmationKey TEXT NOT NULL,
  reservationAddress TEXT NOT NULL,
  reservationDate TEXT NOT NULL,
  creatorId VARCHAR(255) NOT NULL,
  tripId INT NOT NULL,
  cost TEXT NOT NULL,
  FOREIGN KEY (tripId) REFERENCES trips(id) ON DELETE CASCADE,
  FOREIGN KEY (creatorId) REFERENCES accounts(id)
) default charset utf8 COMMENT '';
CREATE TABLE IF NOT EXISTS trips(
  id INT NOT NULL AUTO_INCREMENT primary key,
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  tripName TEXT NOT NULL,
  creatorId VARCHAR(255) NOT NULL,
  FOREIGN KEY (creatorId) REFERENCES accounts(id)
) default charset utf8 COMMENT '';
DROP TABLE trips