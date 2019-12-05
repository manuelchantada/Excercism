module BinarySearchTree



type Tree = 
    | Empty
    | Node of value: int * left: Tree * right: Tree

let left node  = 

let right node = failwith "You need to implement this function."

let data node = failwith "You need to implement this function."

let create items = match items with
                    | head :: [] -> Node (head, Empty, Empty)  
                    | head :: tail -> Node (head )

let rec insert newValue (tree:Tree)  = match tree with
                                        | Empty -> Node(newValue, Empty, Empty) 
                                        | Node (value, left, _) when newValue < value -> 
                                            let left' = insert newValue left
                                            Node (value, left', right)
                                        | Node (value, _, right) when newValue > value -> 
                                            let right' = insert newValue right
                                            Node (value, left, right')
                                        | _ -> tree