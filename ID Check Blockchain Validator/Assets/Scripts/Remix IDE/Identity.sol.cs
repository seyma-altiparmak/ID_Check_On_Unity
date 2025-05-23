/*
// Identity.sol
pragma solidity ^0.8.0;

contract Identity {
    mapping(address => string) public users;

    function register(string memory name) public {
        users[msg.sender] = name;
    }

    function getIdentity(address user) public view returns (string memory) {
        return users[user];
    }
}

*/