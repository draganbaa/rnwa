const { GraphQLObjectType, GraphQLInt, GraphQLString, GraphQLList } = require('graphql');
const { dbQuery } = require('../database');
const UserType = require('./User');

const PostType = new GraphQLObjectType({
  name: 'Marks',
  fields:
    {
      id: { type: GraphQLInt },
      student_roll_num: { type: GraphQLInt },
      subject_id: { type: GraphQLInt },
      marks: { type: GraphQLInt },
      user: { 
        type: UserType,
        resolve: async (post) => {
          let res = await dbQuery(`SELECT * FROM students WHERE roll_num = ${parseInt(post.student_roll_num)}`);
          return res[0];
        }
    }
  }
  
});

module.exports = PostType;