// This is the main entry point for the migration logic
import * as emu from "./emu-migration";

// Load the configuration from the JSON file
const config = emu.loadConfig("./config.json");

// Create a new migration instance with the config
const migration = new emu.Migration(config);

// Run the migration and handle any errors
migration.run()
  .then(() => {
    console.log("Migration completed successfully");
  })
  .catch((error) => {
    console.error("Migration failed:", error);
  });
