const { GraphQLInt, GraphQLString, GraphQLList, GraphQLSchema, GraphQLObjectType, GraphQLInputObjectType } = require('graphql');
const { dbQuery } = require('../../database');
const { UserType } = require('../../types');
const { PostType } = require('../../types');


const fieldsUser = {
  type: UserType,
  args: {
    roll_num: { type: GraphQLInt },
    first_name: { type: GraphQLString },
    last_name: { type: GraphQLString },
    
  },
  async resolve(_, { roll_num }){
    let res = await dbQuery(`SELECT * FROM students WHERE roll_num = ${roll_num}`);
    //let res2 = await dbQuery(`SELECT * FROM marks WHERE roll_num = ${roll_num}`);
    return res[0];
  }
};






module.exports = fieldsUser;


