const { GraphQLList } = require('graphql');
const { dbQuery } = require('../../database');
const { DepType } = require('../../types');

const fieldsDep = {
  type: new GraphQLList(DepType),
  async resolve(_, {}){
    let res = await dbQuery(`SELECT * FROM departments`);

    return res;
  }
};

module.exports = fieldsDep;