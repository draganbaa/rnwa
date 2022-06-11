const { GraphQLList } = require('graphql');
const { dbQuery } = require('../../database');
const { FacType } = require('../../types');

const fieldsFac = {
  type: new GraphQLList(FacType),
  async resolve(_, {}){
    let res = await dbQuery(`SELECT * FROM faculty`);

    return res;
  }
};

module.exports = fieldsFac;