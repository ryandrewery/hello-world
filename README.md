# EMU Migration Project

This project is a tool for managing a migration from a PostgreSQL database to a MySQL database using the EMU (Extract, Map, and Update) method.

## Usage

To run the migration, you need to have Node.js and npm installed, and the source and target databases running and accessible.

First, install the dependencies with:

```bash
npm install
```

Then, edit the `emu-migration/config.json` file with the appropriate parameters for the source and target databases, the mapping of schemas and tables, and the validation rules.

Finally, run the migration with:

```bash
npm start
```

The migration will copy and transform the data from the source to the target, check the integrity and consistency of the data, and log the progress and errors.

## Dependencies

This project depends on the following libraries:

- `pg` for connecting to the PostgreSQL database
- `mysql2` for connecting to the MySQL database
- `jest` for testing the migration logic

## Testing

To run the tests, you need to have `jest` installed as a development dependency. You can do this with:

```bash
npm install --save-dev jest
```

Then, run the tests with:

```bash
npm test
```

The tests will cover the unit and integration tests for the `emu-migration` library module.
