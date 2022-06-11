const { GraphQLString, GraphQLInt } = require('graphql');
const { dbQuery } = require('../../database');
const { DepType } = require('../../types');

const insertDep = {
  type: DepType,
  args: {
    id: { type: GraphQLInt },
    name: { type: GraphQLString },
    hod_id: { type: GraphQLInt }
  },
  async resolve(_, { id, name, hod_id }){
    let res = await dbQuery(`insert into departments (id,name,hod_id) values (${id},'${name}',${hod_id})`);
    return {id, name, hod_id}
  }
};

module.exports = insertDep;