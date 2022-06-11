const { GraphQLObjectType } = require('graphql');
const insertUser = require('./insertUser');
const insertDep = require('./insertDepartment');
const updateFaculty = require('./updateFaculty');

const Mutation = new GraphQLObjectType({
  name: 'mutation',
  fields: {
    // Insert a new user record 
    roll_num: insertUser,
    first_name: insertUser,
    last_name: insertUser,   
    insertUser: insertUser,
    insertDep: insertDep,
    updateFac: updateFaculty
  }
});

module.exports = Mutation;
