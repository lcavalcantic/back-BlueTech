CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

START TRANSACTION;

CREATE TABLE "Contatos" (
    "Id" SERIAL NOT NULL,
    "Nome" varchar(255) NULL,
    "Telefone" varchar(255) NULL,
    "Email" varchar(255) NULL,
    CONSTRAINT "PK_Contatos" PRIMARY KEY ("Id")
);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20231227132009_InitialCreate', '6.0.15');

COMMIT;

START TRANSACTION;

ALTER TABLE "Contatos" DROP CONSTRAINT "PK_Contatos";

ALTER TABLE "Contatos" RENAME TO tb_contatos;

ALTER TABLE tb_contatos RENAME COLUMN "Telefone" TO telefone;

ALTER TABLE tb_contatos RENAME COLUMN "Email" TO email;

ALTER TABLE tb_contatos RENAME COLUMN "Id" TO id;

ALTER TABLE tb_contatos RENAME COLUMN "Nome" TO nome;

UPDATE tb_contatos SET telefone = ''
WHERE telefone IS NULL;

ALTER TABLE tb_contatos ALTER COLUMN telefone SET NOT NULL;

UPDATE tb_contatos SET email = ''
WHERE email IS NULL;

ALTER TABLE tb_contatos ALTER COLUMN email SET NOT NULL;

UPDATE tb_contatos SET name = ''
WHERE name IS NULL;

ALTER TABLE tb_contatos ALTER COLUMN name SET NOT NULL;

ALTER TABLE tb_contatos ADD CONSTRAINT "PK_tb_contatos" PRIMARY KEY (id);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20231227133526_AtualizacaoAgenda', '6.0.15');

COMMIT;

START TRANSACTION;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20231227133848_AtualizacaoAgenda2', '6.0.15');

COMMIT;

