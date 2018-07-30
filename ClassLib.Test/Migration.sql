CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

CREATE TABLE "Customers" (
    "CustomerId" serial NOT NULL,
    "Name" text NULL,
    "Age" integer NOT NULL,
    CONSTRAINT "PK_Customers" PRIMARY KEY ("CustomerId")
);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20180717034938_Migration00', '2.1.1-rtm-30846');

INSERT INTO "Customers" ("CustomerId", "Age", "Name")
VALUES (1, 18, 'Sam');

INSERT INTO "Customers" ("CustomerId", "Age", "Name")
VALUES (2, 19, 'Kevin');

INSERT INTO "Customers" ("CustomerId", "Age", "Name")
VALUES (3, 20, 'John');

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20180717035223_Migration01', '2.1.1-rtm-30846');