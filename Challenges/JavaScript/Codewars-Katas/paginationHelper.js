// For this exercise you will be strengthening your page-fu mastery. You will complete the PaginationHelper class, which is a utility class helpful for querying paging information related to an array.

// The class is designed to take in an array of values and an integer indicating how many items will be allowed per each page. The types of values contained within the collection/array are not relevant.

// The following are some examples of how this class is used:

function PaginationHelper(collection, itemsPerPage){
  this.collection = collection;
  this.itemsPerPage = itemsPerPage;
}

PaginationHelper.prototype.itemCount = function() {
  return this.collection.length;
}

PaginationHelper.prototype.pageCount = function() {
  return Math.floor(this.itemCount()/this.itemsPerPage)+1;
}

PaginationHelper.prototype.pageItemCount = function(pageIndex) {
  if (pageIndex > this.pageCount() - 1 || pageIndex < 0) return -1;
  else if (pageIndex < this.pageCount() - 1) return this.itemsPerPage;
  else return this.itemCount() % this.itemsPerPage;
}

PaginationHelper.prototype.pageIndex = function(itemIndex) {
  if (!this.collection.length || itemIndex < 0 || itemIndex > this.itemCount()) return -1
  else return Math.floor(itemIndex/this.itemsPerPage);
}


helper = PaginationHelper.new(['a','b','c','d','e','f'], 4)
console.log(helper.page_count); // should == 2
console.log(helper.item_count); // should == 6
console.log(helper.page_item_count(0));  // should == 4
console.log(helper.page_item_count(1)); // last page - should == 2
console.log(helper.page_item_count(2)); // should == -1 since the page is invalid

// page_ndex takes an item index and returns the page that it belongs on
console.log(helper.page_index(5)); // should == 1 (zero based index)
console.log(helper.page_index(2)); // should == 0
console.log(helper.page_index(20)); // should == -1
console.log(helper.page_index(-10)); // should == -1 because negative indexes are invalid