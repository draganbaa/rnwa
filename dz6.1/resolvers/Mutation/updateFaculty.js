const { GraphQLString, GraphQLInt } = require('graphql');
const { dbQuery } = require('../../database');
const { FacType } = require('../../types');

const updatefaculty = {
  type: FacType,
  args: {
    id: { type: GraphQLInt },
    first_name: { type: GraphQLString },
    last_name: { type: GraphQLString },
    department_id:{ type: GraphQLInt },
    phone:{ type: GraphQLInt },
  },
  async resolve(_, {id, first_name, last_name, department_id, phone }){
    let res = await dbQuery(`update faculty set first_name= "${first_name}", last_name= "${last_name}"  where id = ${id};`);
    return { id, first_name, last_name, department_id, phone }
  }
};

module.exports = updatefaculty;