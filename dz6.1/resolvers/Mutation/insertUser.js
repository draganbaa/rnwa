const { GraphQLString } = require('graphql');
const { GraphQLInt } = require('graphql');
const { dbQuery } = require('../../database');
const { UserType } = require('../../types');

const insertUser = {
  type: UserType,
  args: {
    roll_num: { type: GraphQLInt },
    first_name: { type: GraphQLString },
    last_name: { type: GraphQLString }
  },
  async resolve(_, { roll_num, first_name, last_name }){
    let res = await dbQuery(`insert into students (roll_num, first_name, last_name) values (${roll_num},'${first_name}', '${last_name}')`);
    return {roll_num, first_name, last_name }
  }
};

module.exports = insertUser;