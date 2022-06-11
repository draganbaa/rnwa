const { GraphQLObjectType, GraphQLInt, GraphQLString, GraphQLList } = require('graphql');


const UserType = new GraphQLObjectType({
  name: 'User',
  fields: {
    roll_num: { type: GraphQLInt },
    first_name: { type: GraphQLString },
    last_name: { type: GraphQLString },  
    
}
});

module.exports = UserType;