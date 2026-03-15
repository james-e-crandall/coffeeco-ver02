module.exports = {
  "/api": {
    target:
      process.env["services__dab__https__0"] ||
      process.env["services__dab__http__0"],
    secure: process.env["NODE_ENV"] !== "development"
  },
  "/graphql": {
    target:
      process.env["services__dab__https__0"] ||
      process.env["services__dab__http__0"],
    secure: process.env["NODE_ENV"] !== "development"
  },
};
