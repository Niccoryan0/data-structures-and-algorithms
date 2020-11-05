'use strict';

const util = require('util');

class Vertex {
  constructor(value) {
    this.value = value;
  }
}

class Edge {
  constructor(vertex, weight) {
    this.vertex = vertex;
    this.weight = weight;
  }
}

class Graph {
  constructor(count) {
    this.adjacencylist = new Map();
  }

  addNode(value) {
    const vertex = new Vertex(value);
    this.adjacencylist.set(vertex, []);

    return vertex;
  }

  addEdge(startVertex, endVertex, weight=0) {
    if (!this.adjacencylist.has(startVertex) || !this.adjacencylist.has(endVertex)) {
      return 'Invalid Vertices';
    }
    const edges = this.adjacencylist.get(startVertex);
    edges.push(new Edge(endVertex, weight));
  }

  getNeighbors(vertex) {
    if (!this.adjacencylist.has(vertex)) {
      return 'Invalid Vertex';
    }

    return [...this.adjacencylist.get(vertex)];
  }

  getNodes() {
    let nodes = [];
    for (let node of this.adjacencylist) {
      nodes.push(node);
    }
    return nodes;
  }
  size() {
    return this.adjacencylist.size;
  }
  }

module.exports = Graph;