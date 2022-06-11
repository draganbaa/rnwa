const { GraphQLObjectType, GraphQLInt, GraphQLString, GraphQLList } = require('graphql');
//const UserType = require('./User');
const FacType = require('./Faculty');
const { dbQuery } = require('../database');


const DepType = new GraphQLObjectType({
  name: 'Departments',
  fields:{
      id: { type: GraphQLInt },
      name: { type: GraphQLString },
      hod_id:{ type: GraphQLInt },
      fac: { 
        type: FacType,
        resolve: async (post) => {
          let res = await dbQuery(`SELECT * FROM faculty WHERE id = ${parseInt(post.hod_id)}`);
          return res[0];
        }
    }
  }
});

module.exports = DepType;