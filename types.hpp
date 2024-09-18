#ifndef TYPES_HPP
#define TYPES_HPP

#include <cstdint>
#include <initializer_list>
#include <optional>
#include <string>
#include <variant>

typedef int32_t integer;
typedef std::initializer_list<integer> integer_list;
typedef std::string string;
typedef std::initializer_list<string> string_list;
typedef std::optional<string> opt_string;

typedef std::variant<integer, string, double, bool> variable;
typedef std::initializer_list<variable> variable_list;
typedef std::optional<variable> opt_variable;
typedef std::variant<string, integer[4]> rect;

enum class anchor {
    CENTER, LEFTUPPER, RIGHTUPPER, LEFTLOWER, RIGHTLOWER, LEFT, RIGHT, TOP, BOTTOM
};

#endif
