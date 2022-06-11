const { GraphQLObjectType, GraphQLInt, GraphQLString, GraphQLList } = require('graphql');



const FacType = new GraphQLObjectType({
  name: 'Faculty',
  fields:{
      id: { type: GraphQLInt },
      first_name: { type: GraphQLString },
      last_name: { type: GraphQLString },
      department_id:{ type: GraphQLInt },
      phone:{ type: GraphQLInt },
    }
   
});

module.exports = FacType;